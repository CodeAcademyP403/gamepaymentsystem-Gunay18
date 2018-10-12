using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GamePaymentSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return RedirectToAction("Index", "Home", new { area = "Admin" });
        }
    }
}