using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Attribute
{
    public class APIAttributes : ActionFilterAttribute
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// Controller進入前會進來
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("API_1");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        ///  Controller結束後
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("API_2");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// 切換畫面前進入的FUNCTION
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("API_3");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// 整體結束後進入的FUNCTION
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("API_4");
        }


    }
}
