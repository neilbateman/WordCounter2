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
        RepeatCounter myWordSentence = new RepeatCounter(word, sentence);
        return RedirectToAction("Index");

    }




    // [HttpGet("/")]
    // public ActionResult Index()
    // {
    //   return View();
    // }
  }
}