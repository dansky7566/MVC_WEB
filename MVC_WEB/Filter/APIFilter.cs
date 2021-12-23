using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Filter
{
    public class APIFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var ControllNameList = new string[] { "API" };

            var ControllerName = (string)context.RouteData.Values["Controller"];  //取得ControllerName
            var ACtionName = (string)context.RouteData.Values["Action"];          //取得ActionName
            
            //於陣列中的API需要做的事情
            if (ControllNameList.Contains(ControllerName))
            {
                Debug.WriteLine("ControllNameList_1  HELLO");
            }


          //  Debug.WriteLine("APIFiler_1");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("APIFiler_2");
        }
    }
}
