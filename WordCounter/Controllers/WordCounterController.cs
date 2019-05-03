using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    
    
    //  [Route("/")]
    // public ActionResult Index()
    // {
    //   Item starterItem = new Item("Add first item to To Do List");
    //   return View(starterItem);
    // }

   [Route("/wordsentences/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [Route("/wordsentences")]
    public ActionResult Create(string sentence, string word)
    {
        WordSentence myWordSentence = new WordSentence(sentence, word);
        return View("Index", myWordSentence);

    }




    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   return View();
    // }
  }
}