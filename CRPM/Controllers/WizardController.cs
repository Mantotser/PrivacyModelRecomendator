using CRPM.Models;
using CRPM.WizardManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRPM.Controllers
{
    public class WizardController : Controller
    {
        public ActionResult Index()
        {
            var wizard = WizardSigleton.Instance;
            wizard.Reset();

            var viewModel = new WizardViewModel
            {
                Name = wizard.CurrentState.Name,
                Question = wizard.CurrentState.Question
            };
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Proceed(WizardViewModel model)
        {
            var wizard = WizardSigleton.Instance;
            bool answer;
            if (bool.TryParse(model.SelectedAnswer, out answer))
            {
                wizard.EnterData(answer);
                wizard.Proceed();

            }
            var viewModel = new WizardViewModel
            {
                Name = wizard.CurrentState.Name,
                Question = wizard.CurrentState.Question
            };


            return View("Index", viewModel);
        }

        [HttpGet]
        public ActionResult GoBack()
        {
            var wizard = WizardSigleton.Instance;
            wizard.Back();
            var viewModel = new WizardViewModel
            {
                Name = wizard.CurrentState.Name,
                Question = wizard.CurrentState.Question
            };


            return View("Index", viewModel);
        }
    }
}