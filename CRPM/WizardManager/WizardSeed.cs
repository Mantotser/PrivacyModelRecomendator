using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkflowManager;
using WorkFlowManager;
using WorkFlowManager.States;

namespace CRPM.WizardManager
{
    public class WizardSeed
    {
        public void Initialize()
        {
            var wizard = WizardSigleton.Instance;

            InitialWizardPage initialState = new InitialWizardPage();
            ApprovalWizardPage pageQ01 = new ApprovalWizardPage("Question number 01")
            {
                Question = "Does the adversary already know that the “victim” exists in the database?"
            };
            ApprovalWizardPage pageQ02 = new ApprovalWizardPage("Question number 02")
            {
                Question = "Is the relational database statistic or not?"
            };
            ApprovalWizardPage pageQ03 = new ApprovalWizardPage("Question number 03")
            {
                Question = "Do the sensitive attributes contain a rich variety of entries?"
            };
            ApprovalWizardPage pageQ04 = new ApprovalWizardPage("Question number 04")
            {
                Question = "Do more than one row entries belong to a single individual?"
            };
            ApprovalWizardPage pageQ05 = new ApprovalWizardPage("Question number 05")
            {
                Question = "Does the dataset contain multiple tables?"
            };
            ApprovalWizardPage pageQ06 = new ApprovalWizardPage("Question number 06")
            {
                Question = "Are the contents of the dataset frequently updated?"
            };
            ApprovalWizardPage pageQ07 = new ApprovalWizardPage("Question number 07")
            {
                Question = "Do the selected quasi-identifiers contain sensitive attributes?"
            };
            ApprovalWizardPage pageQ08 = new ApprovalWizardPage("Question number 08")
            {
                Question = "Are you certain that the quasi-identifiers are precisely known?"
            };
            ApprovalWizardPage pageQ09 = new ApprovalWizardPage("Question number 09")
            {
                Question = "Do most of the attributes contain numerical values?"
            };
            ApprovalWizardPage pageQ10 = new ApprovalWizardPage("Question number 10")
            {
                Question = "Are the sensitive attributes only numeric?"
            };
            ApprovalWizardPage pageQ11 = new ApprovalWizardPage("Question number 11")
            {
                Question = "Is the dataset’s dimensions extremely large?"
            };
            ApprovalWizardPage pageQ12 = new ApprovalWizardPage("Question number 12")
            {
                Question = "Are you able to contact each record owner to ask for his privacy level demands?"
            };
            ApprovalWizardPage pageQ13 = new ApprovalWizardPage("Question number 13")
            {
                Question = "Do you want to be able to specify protection level against specific sensitive attributes?"
            };
            ApprovalWizardPage pageQ14 = new ApprovalWizardPage("Question number 14")
            {
                Question = "Do you wish to be able to determine qid-grouping size and the breach probability of each sensitive attribute?"
            };
            ApprovalWizardPage pageQ15 = new ApprovalWizardPage("Question number 15")
            {
                Question = "Are the sensitive attributes skewed distributed?"
            };


            WizardPage finalPage01 = new FinalWizardPage
            {
                Result = "ε-differential",
                Link = "https://www.utdallas.edu/~muratk/courses/privacy08f_files/differential-privacy.pdf"
            };
            WizardPage finalPage02 = new FinalWizardPage
            {
                Result = "δ-presence",
                Link = "https://docs.lib.purdue.edu/cgi/viewcontent.cgi?article=2702&context=cstech"
            };
            WizardPage finalPage03 = new FinalWizardPage
            {
                Result = "(X -Y) Privacy",
                Link = "https://www.cs.sfu.ca/~wangk/pub/WF06kdd.pdf"
            };
            WizardPage finalPage04 = new FinalWizardPage
            {
                Result = "MultiRelational k-Anonymity",
                Link = "http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.88.5190&rep=rep1&type=pdf"
            };
            WizardPage finalPage05 = new FinalWizardPage
            {
                Result = "m-invariance",
                Link = "http://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.100.3713&rep=rep1&type=pdf"
            };
            WizardPage finalPage06 = new FinalWizardPage
            {
                Result = "FF-Anonymity",
                Link = "http://www.cs.cuhk.hk/~adafu/Pub/FFanonymity.icde09.pdf"
            };
            WizardPage finalPage07 = new FinalWizardPage
            {
                Result = "k-anonymity",
                Link = "https://epic.org/privacy/reidentification/Sweeney_Article.pdf"
            };
            WizardPage finalPage08 = new FinalWizardPage
            {
                Result = "(c, t)-isolation",
                Link = "https://www.microsoft.com/en-us/research/wp-content/uploads/2016/02/tcc05-cdmsw.pdf"
            };
            WizardPage finalPage09 = new FinalWizardPage
            {
                Result = "(e, m)-anonymity",
                Link = "http://www4.ncsu.edu/~tyu/pubs/k-permutation-icde07.pdf"
            };
            WizardPage finalPage10 = new FinalWizardPage
            {
                Result = "(k, e)-anonymity",
                Link = "http://pages.cs.wisc.edu/~jxli/includes/pubs/sigmod2008.pdf"
            };
            WizardPage finalPage11 = new FinalWizardPage
            {
                Result = "LKC-privacy",
                Link = "http://dmas.lab.mcgill.ca/fung/pub/MFHL09kdd.pdf"
            };
            WizardPage finalPage12 = new FinalWizardPage
            {
                Result = "Personalized Privacy Preservation",
                Link = "http://www.cse.cuhk.edu.hk/~taoyf/paper/sigmod06.pdf"
            };
            WizardPage finalPage13 = new FinalWizardPage
            {
                Result = "Confidence Bounding",
                Link = "http://dmas.lab.mcgill.ca/fung/pub/WFY07kais.pdf"
            };
            WizardPage finalPage14 = new FinalWizardPage
            {
                Result = "(a, k)-anonymity",
                Link = "https://pdfs.semanticscholar.org/bbf2/d272d9b326a3079335461d585602b871e136.pdf"
            };
            WizardPage finalPage15 = new FinalWizardPage
            {
                Result = "t-closeness",
                Link = "https://www.cs.purdue.edu/homes/ninghui/papers/t_closeness_icde07.pdf"
            };
            WizardPage finalPage16 = new FinalWizardPage
            {
                Result = "l-diversity",
                Link = "https://www.utdallas.edu/~muratk/courses/privacy08f_files/ldiversity.pdf"
            };
            

            wizard.InitialState = initialState;
            wizard.States.Add(pageQ01);
            wizard.States.Add(pageQ02);
            wizard.States.Add(pageQ03);
            wizard.States.Add(pageQ04);
            wizard.States.Add(pageQ05);
            wizard.States.Add(pageQ06);
            wizard.States.Add(pageQ07);
            wizard.States.Add(pageQ08);
            wizard.States.Add(pageQ09);
            wizard.States.Add(pageQ10);
            wizard.States.Add(pageQ11);
            wizard.States.Add(pageQ12);
            wizard.States.Add(pageQ13);
            wizard.States.Add(pageQ14);
            wizard.States.Add(pageQ15);
            wizard.States.Add(finalPage01);
            wizard.States.Add(finalPage02);
            wizard.States.Add(finalPage03);
            wizard.States.Add(finalPage04);
            wizard.States.Add(finalPage05);
            wizard.States.Add(finalPage06);
            wizard.States.Add(finalPage07);
            wizard.States.Add(finalPage08);
            wizard.States.Add(finalPage09);
            wizard.States.Add(finalPage10);
            wizard.States.Add(finalPage11);
            wizard.States.Add(finalPage12);
            wizard.States.Add(finalPage13);
            wizard.States.Add(finalPage14);
            wizard.States.Add(finalPage15);
            wizard.States.Add(finalPage16);

            Connection fromInitialToApprovalCon = new Connection(initialState, pageQ01);
            initialState.Start = fromInitialToApprovalCon;

            //Q01
            Connection appQ01Q03 = new Connection(pageQ01, pageQ03);
            Connection disAppQ01Q02 = new Connection(pageQ01, pageQ02);
            pageQ01.ApprovedConnection = appQ01Q03;
            pageQ01.DisapprovedConnection = disAppQ01Q02;

            //Q02
            Connection appQ02F01 = new Connection(pageQ02, finalPage01);
            Connection disAppQ02F02 = new Connection(pageQ02, finalPage02);
            pageQ02.ApprovedConnection = appQ02F01;
            pageQ02.DisapprovedConnection = disAppQ02F02;

            //Q03
            Connection appQ03Q11 = new Connection(pageQ03, pageQ11);
            Connection disAppQ03Q04 = new Connection(pageQ03, pageQ04);
            pageQ03.ApprovedConnection = appQ03Q11;
            pageQ03.DisapprovedConnection = disAppQ03Q04;

            //Q04
            Connection appQ04F03 = new Connection(pageQ04, finalPage03);
            Connection disAppQ04Q05 = new Connection(pageQ04, pageQ05);
            pageQ04.ApprovedConnection = appQ04F03;
            pageQ04.DisapprovedConnection = disAppQ04Q05;

            //Q05
            Connection appQ05F04 = new Connection(pageQ05, finalPage04);
            Connection disAppQ05Q06 = new Connection(pageQ05, pageQ06);
            pageQ05.ApprovedConnection = appQ05F04;
            pageQ05.DisapprovedConnection = disAppQ05Q06;

            //Q06
            Connection appQ06F05 = new Connection(pageQ06, finalPage05);
            Connection disAppQ06Q07 = new Connection(pageQ06, pageQ07);
            pageQ06.ApprovedConnection = appQ06F05;
            pageQ06.DisapprovedConnection = disAppQ06Q07;

            //Q07
            Connection appQ07F06 = new Connection(pageQ07, finalPage06);
            Connection disAppQ07Q08 = new Connection(pageQ07, pageQ08);
            pageQ07.ApprovedConnection = appQ07F06;
            pageQ07.DisapprovedConnection = disAppQ07Q08;

            //Q08
            Connection appQ08F07 = new Connection(pageQ08, finalPage07);
            Connection disAppQ08Q09 = new Connection(pageQ08, pageQ09);
            pageQ08.ApprovedConnection = appQ08F07;
            pageQ08.DisapprovedConnection = disAppQ08Q09;

            //Q09
            Connection appQ09F08 = new Connection(pageQ09, finalPage08);
            Connection disAppQ09Q10 = new Connection(pageQ09, pageQ10);
            pageQ09.ApprovedConnection = appQ09F08;
            pageQ09.DisapprovedConnection = disAppQ09Q10;

            //Q10
            Connection appQ10F09 = new Connection(pageQ10, finalPage09);
            Connection disAppQ10F10 = new Connection(pageQ10, finalPage10);
            pageQ10.ApprovedConnection = appQ10F09;
            pageQ10.DisapprovedConnection = disAppQ10F10;

            //Q11
            Connection appQ11F11 = new Connection(pageQ11, finalPage11);
            Connection disAppQ11Q12 = new Connection(pageQ11, pageQ12);
            pageQ11.ApprovedConnection = appQ11F11;
            pageQ11.DisapprovedConnection = disAppQ11Q12;

            //Q12
            Connection appQ12F12 = new Connection(pageQ12, finalPage12);
            Connection disAppQ12Q13 = new Connection(pageQ12, pageQ13);
            pageQ12.ApprovedConnection = appQ12F12;
            pageQ12.DisapprovedConnection = disAppQ12Q13;

            //Q13
            Connection appQ13F13 = new Connection(pageQ13, finalPage13);
            Connection disAppQ13Q14 = new Connection(pageQ13, pageQ14);
            pageQ13.ApprovedConnection = appQ13F13;
            pageQ13.DisapprovedConnection = disAppQ13Q14;

            //Q14
            Connection appQ14F14 = new Connection(pageQ14, finalPage14);
            Connection disAppQ14Q15 = new Connection(pageQ14, pageQ15);
            pageQ14.ApprovedConnection = appQ14F14;
            pageQ14.DisapprovedConnection = disAppQ14Q15;

            //Q15
            Connection appQ15F15 = new Connection(pageQ15, finalPage15);
            Connection disAppQ15F16 = new Connection(pageQ15, finalPage16);
            pageQ15.ApprovedConnection = appQ15F15;
            pageQ15.DisapprovedConnection = disAppQ15F16;

        }
    }
}