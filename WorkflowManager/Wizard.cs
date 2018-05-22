using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowManager
{
    public class Wizard
    {
        public int Step { get; set; }
        public List<WizardPage> History { get; set; }
        public string Name { get; set; }
        public ICollection<WizardPage> States { get; set; }
        public WizardPage InitialState { get; set; }
        public WizardPage CurrentState { get; set; }
        public void Reset()
        {
            this.CurrentState = InitialState.Next();
            this.History.Add(this.CurrentState);
            this.Step = 0;
        }
        public void ClearData()
        {
            this.States.ToList().ForEach(f => f.ClearData());
        }
        public virtual void Proceed()
        {
            this.CurrentState = this.CurrentState.Next();
            this.History.Add(this.CurrentState);
            this.Step += 1;
        }

        public void Back()
        {
            if (this.Step != 0)
            {
                this.Step -= 1;
                this.CurrentState = this.History[Step];
            }
        }

        public virtual void EnterData(bool answer)
        {
            this.CurrentState.SetData(answer);
        }
        public Wizard()
        {
            this.States = new List<WizardPage>();
            this.Step = 0;
            this.History = new List<WizardPage>();
        }
    }
}
