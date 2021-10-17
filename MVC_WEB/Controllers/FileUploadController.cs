using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Controllers
{
    public class FileUploadController : Controller
    {

        #region 基本上傳方式

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult FileUpload(IFormFile FileUpload)
        {
            return View();
        }
        #endregion

        #region 前台上傳方式

        public IActionResult FrontEnd()
        {
            return View();
        }

        public IActionResult FrontUpload(List<IFormFile> FileUpload)
        {
            return View();
        }

        #endregion


    }
}
