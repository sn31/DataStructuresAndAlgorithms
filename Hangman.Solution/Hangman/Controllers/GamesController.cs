using System;
using System.Collections.Generic;
using Hangman.Models;
using Microsoft.AspNetCore.Mvc;
namespace Hangman.Controllers
{
    public class GamesController : Controller
    {

        [HttpGet("/game")]
        public ActionResult Index()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            Game newGame = new Game { };
            result.Add("GameStatus", Game.gameStatus);
            result.Add("GameObject", newGame);
            
            return View(result);
        }

        [HttpPost("/game")]
        public ActionResult CreateForm()
        {
            Dictionary<string, object> result = new Dictionary<string, object>();
            Game newGame = new Game { };
            
            List<string> guesses = newGame.GetGuesses();
            result.Add("GameStatus", Game.gameStatus);
            result.Add("GameObject", newGame);
            result.Add("GameMessage", newGame.FindChar(Request.Form["new-guess"]));
            return View(result);
        }
    }
}