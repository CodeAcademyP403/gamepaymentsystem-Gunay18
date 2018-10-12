using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePaymentSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamePaymentSystem.Areas.Admin.Controllers
{ 
    [Area("Admin")]
    public class HomeController : Controller
    {
        private GamePaymentDbContext _gamePaymentDbContext;

        public HomeController(GamePaymentDbContext gamePaymentDbContext)
        {
            _gamePaymentDbContext = gamePaymentDbContext;
        }

        public IActionResult Index()
        {
            var payments=_gamePaymentDbContext.Payments.ToList();

            return View(payments);
        }
    }
}