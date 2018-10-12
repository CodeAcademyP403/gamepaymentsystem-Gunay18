using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamePaymentSystem.Models;
using GamePaymentSystem.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GamePaymentSystem.Controllers
{
    public class TransactionController : Controller
    {
        private GamePaymentDbContext _GamePaymentDbContext;
        private Game clickedGame;

        private IHttpContextAccessor _accessor;

        public TransactionController(GamePaymentDbContext gamePaymentDbContext, IHttpContextAccessor accessor)
        {
            _GamePaymentDbContext = gamePaymentDbContext;
            _accessor = accessor;
        }

        public IActionResult Payment(int Id)
        {
            clickedGame =_GamePaymentDbContext.Games.Where(x =>
                x.Id == Id).SingleOrDefault();

            HttpContext.Session.SetString("Name", clickedGame.Name);
            HttpContext.Session.SetString("Id", clickedGame.Id.ToString());
            HttpContext.Session.SetString("MinPrice", clickedGame.MinPrice.ToString());
            HttpContext.Session.SetString("MaxPrice", clickedGame.MaxPrice.ToString());
            HttpContext.Session.SetString("Url", clickedGame.Url);

            GameModel gameModel = new GameModel();
            
            return View(gameModel);
        }

        [HttpPost]
        public IActionResult Payment(GameModel gameModel)
        {

            Payment payment = new Payment()
            {
                GameId = Convert.ToInt32(HttpContext.Session.GetString("Id")),
                UserIP = _accessor.HttpContext.Connection.RemoteIpAddress.ToString(),
                PaymentTime = DateTime.Today,
                Status = true,
                Price = gameModel.Price
             };
            _GamePaymentDbContext.Payments.Add(payment);
            _GamePaymentDbContext.SaveChanges();
            return Redirect(HttpContext.Session.GetString("Url"));
        }



    }
}