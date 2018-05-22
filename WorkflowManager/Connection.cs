using WorkflowManager;

namespace WorkFlowManager
{
    public class Connection
    {
        public WizardPage From { get; set; }
        public WizardPage To { get; set; }

        public Connection(WizardPage from, WizardPage to)
        {
            this.From = from;
            this.To = to;
        }
    }
}