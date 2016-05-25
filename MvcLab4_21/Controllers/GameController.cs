using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLab4_21.Models;

namespace MvcLab4_21.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var game = new Game_21();

            this.Session["game"] = game;
            return View();
        }


        public PartialViewResult Game(int add)
        {
            var game = (Game_21)this.Session["game"];
            game.AddNr(add);
            return PartialView(game);
        }
    }
}