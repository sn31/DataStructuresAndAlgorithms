using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
namespace WordCounter.Controllers
{
    public class WordCounterController:Controller{
        [HttpGet("/wordcounter")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/wordcounter/result")]
        public ActionResult Result()
        {
            string inputWord = Request.Form["new-word"];
            string inputString = Request.Form["new-string"];
            bool Validity = RepeatCounter.ValidityCheck(inputWord);
            Dictionary<string,object> Result = new Dictionary<string,object>{};
            
            if (Validity)
            {
                Result.Add("Result", RepeatCounter.Counter(inputWord,inputString));
                Result.Add("Message", "Your input keyword is valid.");
            }
            else 
            {
                Result.Add("Message", "Please enter a valid keyword!");
                Result.Add("Result", "Cannot compute!");
            }
            return View(Result);
        }
    }
}