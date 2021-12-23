using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_WEB.Attribute;
using MVC_WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MVC_WEB.Controllers
{
  
   [APIAttributes]   //嘗試了一下 還是只能在Controller上用 Attributes的方式，還是沒法用Filter的方式
    public class APIController : Controller
    {
        public IActionResult TestModel()
        {
            var testData = "Hello API";
            return Json(testData);
        }
    }
}
