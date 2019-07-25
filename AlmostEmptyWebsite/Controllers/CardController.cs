using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AlmostEmptyWebsite.Controllers
{
    public class CardController : Controller
    {
        public IActionResult DummyCard()
        {
            return View();
        }
    }
}