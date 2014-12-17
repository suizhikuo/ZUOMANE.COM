using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM.ZUOMANE.Portal.Filters
{
	public class ActionFillter : FilterAttribute, IActionFilter
	{
		public void OnActionExecuted(ActionExecutedContext filterContext)
		{
			//执行action后执行这个方法 比如做操作日志
		}
		public void OnActionExecuting(ActionExecutingContext filterContext)
		{
			//执行action前执行这个方法,比如做身份验证
		}
	}
}