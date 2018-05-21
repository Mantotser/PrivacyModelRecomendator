using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowManager;

namespace WorkFlowManager.States
{
    public class InitialState : State
    {
        public InitialState() : base(nameof(InitialState))
        {
        }

        public Connection Start { get; set; }

        public override void AddConnection(Connection conn, ConnectionMode mode)
        {
            this.Start = conn;
        }

        public override State Next()
        {
            return this.Start.To;
        }
    }
}
