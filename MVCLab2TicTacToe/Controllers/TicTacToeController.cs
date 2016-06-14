using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLab2TicTacToe.Models;

namespace MVCLab2TicTacToe.Controllers
{
    public class TicTacToeController : Controller
    {
        // GET: TicTacToe
        public ActionResult Index()
        {
            TicTacToeModel m = new TicTacToeModel();
            return View(m);
        }

        [HttpPost]
        public ActionResult Index(TicTacToeModel model)
        {
            if (!model.GameOver)
            {
                model.AddNumber();
                model.CheckIfWon();
                ModelState.Clear();
            }
            return View(model);
        }
    }
}