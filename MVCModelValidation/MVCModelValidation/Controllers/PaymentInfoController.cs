using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCModelValidation.Models;

namespace MVCModelValidation.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class PaymentInfoController : Controller
    {
        public IActionResult Index()
        {
            return View("Create");
        }

       
        public IActionResult Create([Bind("CardNumber","ExpiresMonth","ExpiresYear","Name","Email")]PaymentInfo paymentInfo)
        {
            if(ModelState.IsValid)
            {
                return View("Success");
            } else
            {
                return View("Failure");
            }
        }
    }
}