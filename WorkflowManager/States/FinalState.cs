using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowManager;

namespace WorkFlowManager.States
{
    public class FinalState : State
    {
        public FinalState(string name) : base(name)
        {
        }

        public FinalState() : base(nameof(FinalState))
        {
        }

        public override State Next()
        {
            return this;
        }

        public override void AddConnection(Connection conn, ConnectionMode mode)
        {
            throw new NotSupportedException();
        }
    }
}
