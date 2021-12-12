using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Filter
{
    public class InputFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("test1");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("test2");
        }
    }


}
