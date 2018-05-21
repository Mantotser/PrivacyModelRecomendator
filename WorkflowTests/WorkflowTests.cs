using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkFlowManager;
using WorkFlowManager.States;
using WorkflowManager;

namespace WorkflowTests
{
    [TestClass]
    public class WorkflowTests
    {
        [TestMethod]
        public void SimpleInitTest()
        {
            var initiatedWorkflow = new InitiatedWorkflow();
            initiatedWorkflow.Name = "Simple Test";

            InitialState initialState = new InitialState();
            ApprovalState stateQ1 = new ApprovalState("Q1");
            ApprovalState stateQ2 = new ApprovalState("Q2");
            ApprovalState stateQ3 = new ApprovalState("Q3");

            State finalState1 = new FinalState();
            State finalState2 = new FinalState();
            State finalState3 = new FinalState();
            State finalState4 = new FinalState();

            initiatedWorkflow.InitialState = initialState;
            initiatedWorkflow.States.Add(stateQ1);
            initiatedWorkflow.States.Add(stateQ2);
            initiatedWorkflow.States.Add(stateQ3);
            initiatedWorkflow.States.Add(finalState1);
            initiatedWorkflow.States.Add(finalState2);
            initiatedWorkflow.States.Add(finalState3);
            initiatedWorkflow.States.Add(finalState4);

            Connection fromInitialToApprovalCon = new Connection(initialState, stateQ1);
            initialState.Start = fromInitialToApprovalCon;

            //Q1
            Connection appQ1Q3 = new Connection(stateQ1, stateQ3);
            Connection disAppQ1Q2 = new Connection(stateQ1, stateQ2);
            stateQ1.ApprovedConnection = appQ1Q3;
            stateQ1.DisapprovedConnection = disAppQ1Q2;

            //Q2
            Connection appQ2F2 = new Connection(stateQ2, finalState2);
            Connection disAppQ2F1 = new Connection(stateQ2, finalState1);
            stateQ2.ApprovedConnection = appQ2F2;
            stateQ2.DisapprovedConnection = disAppQ2F1;

            //Q3
            Connection appQ3F4 = new Connection(stateQ3, finalState4);
            Connection disAppQ3F3 = new Connection(stateQ3, finalState3);
            stateQ3.ApprovedConnection = appQ3F4;
            stateQ3.DisapprovedConnection = disAppQ3F3;

            initiatedWorkflow.Reset();

            Assert.AreEqual(stateQ1, initiatedWorkflow.CurrentState);

            initiatedWorkflow.CurrentState.SetData(true);
            initiatedWorkflow.Proceed();

            Assert.AreEqual(stateQ3, initiatedWorkflow.CurrentState);

            initiatedWorkflow.CurrentState.SetData(false);
            initiatedWorkflow.Proceed();

            Assert.AreEqual(finalState3, initiatedWorkflow.CurrentState);
        }
    }
}
