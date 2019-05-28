using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UI.ViewModels
{
    public class HomeViewModel : Controller
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
