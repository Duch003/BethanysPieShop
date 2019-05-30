using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    [Authorize]
    public class FeedbackController : Controller
    {
        private readonly IFeedbackRepositroy repository;

        public FeedbackController(IFeedbackRepositroy repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                repository.AddFeedback(feedback);

                return RedirectToAction("FeedbackComplete");
            }
            return View(feedback);

            
        }

        public IActionResult FeedbackComplete()
        {
            return View();
        }
    }
}