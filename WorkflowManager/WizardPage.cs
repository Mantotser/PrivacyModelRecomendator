using WorkFlowManager;

namespace WorkflowManager
{
    public abstract class WizardPage
    {
        public virtual string Name { get; set; }
        public virtual string Question { get; set; }
        public abstract WizardPage Next();
        public virtual void SetData(bool answer) { }

        public WizardPage(string name)
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