using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowManager;

namespace WorkFlowManager.States
{
    public class InitialWizardPage : WizardPage
    {
        public InitialWizardPage() : base(nameof(InitialWizardPage))
        {
        }

        public Connection Start { get; set; }

        public override void AddConnection(Connection conn, ConnectionMode mode)
        {
            this.Start = conn;
        }

        public override WizardPage Next()
        {
            return this.Start.To;
        }
    }
}
