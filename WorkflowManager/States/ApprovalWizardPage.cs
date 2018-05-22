using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowManager;

namespace WorkFlowManager
{
    public class ApprovalWizardPage : WizardPage
    {
        public ApprovalWizardPage(string name) : base(name)
        {
        }

        public Connection ApprovedConnection { get; set; }
        public Connection DisapprovedConnection { get; set; }
        public bool IsApproved { get; set; }
        public override void SetData(bool answer)
        {
            this.IsApproved = answer;
        }
        public override void ClearData()
        {
            this.IsApproved = false;
        }
        public override void AddConnection(Connection conn, ConnectionMode mode)
        {
            switch (mode)
            {
                case ConnectionMode.Positive:
                    this.ApprovedConnection = conn;
                    break;
                case ConnectionMode.Negative:
                    this.DisapprovedConnection = conn;
                    break;
                default:
                    break;
            }
        }

        public override WizardPage Next()
        {
            return IsApproved ? ApprovedConnection.To : DisapprovedConnection.To;
        }
    }
}
