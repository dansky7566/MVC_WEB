using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_WEB.Attribute
{


    public class ExampleAttribute : ActionFilterAttribute
    {

        #region 可自行定義屬性資料

        public string Name { get; set; }

        public string Id { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Id"></param>
        public ExampleAttribute(string Name, string Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

        #endregion



        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// Controller進入前會進來
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("1");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        ///  Controller結束後
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("2");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// 切換畫面前進入的FUNCTION
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Debug.WriteLine("3");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterContext"></param>
        /// 整體結束後進入的FUNCTION
        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Debug.WriteLine("4");
        }


    }
}
