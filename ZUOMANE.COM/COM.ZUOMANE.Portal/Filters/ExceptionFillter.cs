using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COM.ZUOMANE.Portal.Filters
{
	public class ExceptionFillter : FilterAttribute, IExceptionFilter
	{
		//发生异常时会执行这段代码
		public void OnException(ExceptionContext filterContext)
		{
			//在这里你可以记录发生异常时你要干什么，比例写日志
			//这一行告诉系统，这个异常已经处理了，不用再处理
			filterContext.ExceptionHandled = true;
		}
	}
}