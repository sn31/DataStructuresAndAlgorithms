using Microsoft.AspNetCore.Mvc;
using Anagram.Models;
namespace Anagram.Controllers
{
    public class HomeController : Controller
    {
       
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }
        [Route("/Anagram")]
        public ActionResult Anagram()
        {
            AnagramChecker newAnagram = new AnagramChecker();
            newAnagram.SetMainWord(Request.Query["mainWord"]);
            newAnagram.SetWordList(Request.Query["wordStr"]);
            return View("Anagram", newAnagram);
        }
    }
}
