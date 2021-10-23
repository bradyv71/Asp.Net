using System;
using Microsoft.AspNetCore.Mvc;
using Lab03BradyValentine;
using System.Linq;



public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        ViewBag.Total = 0;
        ViewBag.DiscountAmount = 0;
        return View();
    }
    [HttpPost]
    public ActionResult Index(CalculatorModel model)
    {

        if (ModelState.IsValid)
        {
            ViewBag.DiscountAmount = model.CalculateFutureValue();
            ViewBag.Total = model.CalculateTotal();

        }
        else
        {
            ViewBag.Total = 0;
        }
        return View(model);

    }

}