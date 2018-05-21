using WorkFlowManager;

namespace WorkflowManager
{
    public abstract class State
    {
        public virtual string Name { get; set; }
        public virtual string Question { get; set; }
        public abstract State Next();
        public virtual void SetData(bool answer) { }

        public State(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public virtual void ClearData()
        {

        }

        public abstract void AddConnection(Connection conn, ConnectionMode mode);

    }
}