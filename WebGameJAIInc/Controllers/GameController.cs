using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGameJAIInc.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult DinosourJump()
        {
            return View();
        }
        public ActionResult FlappyBird()
        {
            return View();
        }
    }
}