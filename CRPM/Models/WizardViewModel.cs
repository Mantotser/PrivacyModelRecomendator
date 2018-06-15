using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRPM.Models
{
    public class WizardViewModel
    {
        public string Name { get; set; }
        public string Result { get; set; }
        public string Question { get; set; }
        public string Link { get; set; }
        public string SelectedAnswer { get; set; }
    }
}