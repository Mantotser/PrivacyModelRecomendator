using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkflowManager;
using WorkFlowManager;
using WorkFlowManager.States;

namespace CRPM.WizardManager
{
    public class WizardManager
    {
        public void Initialize()
        {
            var wizard = WizardSigleton.Instance;

            InitialWizardPage initialState = new InitialWizardPage();
            ApprovalWizardPage pageQ1 = new ApprovalWizardPage("Q1")
            {
                Question = "Does the attacker know?"
            };
            ApprovalWizardPage pageQ2 = new ApprovalWizardPage("Q2")
            {
                Question = "More than one person per record?"
            };
            ApprovalWizardPage pageQ3 = new ApprovalWizardPage("Q3")
            {
                Question = "Is the database statistic?"
            };

            WizardPage finalPage1 = new FinalWizardPage
            {
                Result = "k-anonymity"
            };
            WizardPage finalPage2 = new FinalWizardPage
            {
                Result = "(X-Y)-Privacy"
            };
            WizardPage finalPage3 = new FinalWizardPage
            {
                Result = "δ-presence"
            };
            WizardPage finalPage4 = new FinalWizardPage
            {
                Result = "ε-differential"
            };

            wizard.InitialState = initialState;
            wizard.States.Add(pageQ1);
            wizard.States.Add(pageQ2);
            wizard.States.Add(pageQ3);
            wizard.States.Add(finalPage1);
            wizard.States.Add(finalPage2);
            wizard.States.Add(finalPage3);
            wizard.States.Add(finalPage4);

            Connection fromInitialToApprovalCon = new Connection(initialState, pageQ1);
            initialState.Start = fromInitialToApprovalCon;

            //Q1
            Connection appQ1Q3 = new Connection(pageQ1, pageQ3);
            Connection disAppQ1Q2 = new Connection(pageQ1, pageQ2);
            pageQ1.ApprovedConnection = appQ1Q3;
            pageQ1.DisapprovedConnection = disAppQ1Q2;

            //Q2
            Connection appQ2F2 = new Connection(pageQ2, finalPage2);
            Connection disAppQ2F1 = new Connection(pageQ2, finalPage1);
            pageQ2.ApprovedConnection = appQ2F2;
            pageQ2.DisapprovedConnection = disAppQ2F1;

            //Q3
            Connection appQ3F4 = new Connection(pageQ3, finalPage4);
            Connection disAppQ3F3 = new Connection(pageQ3, finalPage3);
            pageQ3.ApprovedConnection = appQ3F4;
            pageQ3.DisapprovedConnection = disAppQ3F3;
        }
    }
}