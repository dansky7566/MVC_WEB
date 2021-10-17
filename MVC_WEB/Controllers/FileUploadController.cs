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

        /// <summary>
        /// INDEX畫面
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 檔案上傳
        /// </summary>
        /// <param name="FileUpload"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult FileUpload(IFormFile FileUpload)
        {
            return View();
        }
        #endregion

        #region 前台上傳方式

        /// <summary>
        /// 前台上傳方式頁面
        /// </summary>
        /// <returns></returns>
        public IActionResult FrontEnd()
        {
            return View();
        }

        /// <summary>
        /// 前台上傳方式
        /// </summary>
        /// <param name="FileUpload"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult FrontUpload(List<IFormFile> FileUpload)
        {
            return View();
        }

        #endregion

        #region 做成套件的下載方法

        /// <summary>
        /// 套件頁面方式
        /// </summary>
        /// <returns></returns>
        public IActionResult FrontKit()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="FileUpload"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult FrontKit(List<IFormFile> FileUpload)
        {
            return View();
        }

        #endregion


    }
}
