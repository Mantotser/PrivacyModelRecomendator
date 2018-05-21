using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManager
{
    public abstract class Workflow
    {
        public string Name { get; set; }
        public ICollection<State> States { get; set; }
        public State InitialState { get; set; }
        public State CurrentState { get; set; }
        public void Reset()
        {
            this.CurrentState = InitialState.Next();
        }
        public void ClearData()
        {
            this.States.ToList().ForEach(f => f.ClearData());
        }
        public virtual void Proceed()
        {
            this.CurrentState = this.CurrentState.Next();
        }
        public virtual void EnterData(bool answer)
        {
            this.CurrentState.SetData(answer);
        }
        public Workflow()
        {
            this.States = new List<State>();
        }
    }
}
