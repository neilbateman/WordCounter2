using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;
using System;
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

   [HttpGet("/wordsentences/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    
    [HttpPost("/wordsentences")]
    public ActionResult Create(string sentence, string word)
    {
        WordSentence myWordSentence = new WordSentence(word, sentence);
        return View("Index", myWordSentence);

    }




    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   return View();
    // }
  }
}