using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Calc;
using WebCalc.Models;

namespace WebCalc.Controllers
{
    public class CalcController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Calc(CalcViewModel model)
        {
            var calc = new Calculator();

            var method = typeof(Calculator).GetMethod(model.Operation);

            try
            {
                model.Result = method.Invoke(calc, new object[] { model.X, model.Y }).ToString();
            }
            catch (Exception ex)
            {
                model.Result = ex.Message;
            }

            return View("Index", model);
        }

    }
}