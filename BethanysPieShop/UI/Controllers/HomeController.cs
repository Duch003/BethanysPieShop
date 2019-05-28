using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UI.Models;
using UI.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository repository;

        // GET: /<controller>/
        public HomeController(IPieRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel();
            homeViewModel.Title = "Welcome to Bethany's Pie Shop!";
            homeViewModel.Pies = repository.GetAllPies().OrderBy(item => item.Name).ToList();

            return View(homeViewModel);
        }
    }
}
