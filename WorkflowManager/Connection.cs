using WorkflowManager;

namespace WorkFlowManager
{
    public class Connection
    {
        public State From { get; set; }
        public State To { get; set; }

        public Connection(State from, State to)
        {
            this.From = from;
            this.To = to;
        }
    }
}