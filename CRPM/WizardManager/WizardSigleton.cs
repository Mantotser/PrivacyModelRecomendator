using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorkflowManager;

namespace CRPM.WizardManager
{
    public class WizardSigleton
    {
        private static Wizard _wizard;
        private static object _lock = new object();

        private WizardSigleton() { }

        public static Wizard Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_wizard == null)
                        _wizard = new Wizard();
                    return _wizard;
                }
            }
        }
    }
}