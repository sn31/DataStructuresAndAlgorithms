using MadLibs.Models;
using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public ActionResult Form()
        {
            return View();
        }
        [Route("/story")]
        public ActionResult Story()
        {
            MadLibsVariables newMadLibs = new MadLibsVariables();
            newMadLibs.SetPersonOne(Request.Query["person1"]);
            newMadLibs.SetPersonTwo(Request.Query["person2"]);
            newMadLibs.SetAnimal(Request.Query["animal"]);
            newMadLibs.SetExclamation(Request.Query["exclamation"]);
            newMadLibs.SetVerb(Request.Query["verb"]);
            newMadLibs.SetNoun(Request.Query["noun"]);
            return View("Story", newMadLibs);
        }
    }
}