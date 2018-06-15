using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowManager;

namespace WorkFlowManager.States
{
    public class FinalWizardPage : WizardPage
    {
        public string Result { get; set; }
        public string Link { get; set; }
        public FinalWizardPage(string name) : base(name)
        {
        }

        public FinalWizardPage() : base(nameof(FinalWizardPage))
        {
        }

        public override WizardPage Next()
        {
            return this;
        }

        public override void AddConnection(Connection conn, ConnectionMode mode)
        {
            throw new NotSupportedException();
        }
    }
}
