using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePaymentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamePaymentSystem.Controllers
{
    public class HomeController : Controller
    {
        private GamePaymentDbContext _GamePaymentDbContext; 

        public HomeController(GamePaymentDbContext gamePaymentDbContext)
        {
            _GamePaymentDbContext = gamePaymentDbContext;
        }


        public IActionResult Index()
        {
            var games = _GamePaymentDbContext.Games.ToList();

            return View(games);
        }
    }
}