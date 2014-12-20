using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using COM.ZUOMANE.BLL;
using System.Text;

namespace COM.ZUOMANE.Portal
{
	public class PortalApplication : System.Web.HttpApplication
	{
		/// <summary>
		/// 引用http://www.cnblogs.com/ldp615/archive/2010/10/27/asp-net-mvc-forms-authentication-roles-authorization-demo.html
		/// </summary>
		public PortalApplication()
		{
			AuthorizeRequest += PortalApplication_AuthorizeRequest;			 	
		}

		/// <summary>
		/// 可以使用这种标签了:
		/// [Authorize(Users="admin", Roles = "admin")]
		/// [Authorize(Roles = "manager")]
		/// [Authorize(Roles = "employee,manager")]
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void PortalApplication_AuthorizeRequest(object sender, EventArgs e)
		{
			IIdentity id = Context.User.Identity;
			if (id.IsAuthenticated)
			{
				var roles = new UserBLL().GetRoles(id.Name);
				Context.User = new GenericPrincipal(id, roles);
			}
		}

		/// <summary>
		/// 应用程序初始化
		/// </summary>
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
		
		void Application_Error(object sender, EventArgs e)
		{
			// 在出现未处理的错误时运行的代码 
			Exception ex = Server.GetLastError().GetBaseException();
			StringBuilder str = new StringBuilder();
			str.Append("\r\n" + DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss"));
			str.Append("\r\n.客户信息：");
			
			string ip = "";
			if (Request.ServerVariables.Get("HTTP_X_FORWARDED_FOR") != null)
			{
				ip = Request.ServerVariables.Get("HTTP_X_FORWARDED_FOR").ToString().Trim();
			}
			else
			{
				ip = Request.ServerVariables.Get("Remote_Addr").ToString().Trim();
			}
			str.Append("\r\n\tIp:" + ip);
			str.Append("\r\n\t浏览器:" + Request.Browser.Browser.ToString());
			str.Append("\r\n\t浏览器版本:" + Request.Browser.MajorVersion.ToString());
			str.Append("\r\n\t操作系统:" + Request.Browser.Platform.ToString());
			str.Append("\r\n.错误信息：");
			str.Append("\r\n\t页面：" + Request.Url.ToString());
			str.Append("\r\n\t错误信息：" + ex.Message);
			str.Append("\r\n\t错误源：" + ex.Source);
			str.Append("\r\n\t异常方法：" + ex.TargetSite);
			str.Append("\r\n\t堆栈信息：" + ex.StackTrace);
			str.Append("\r\n--------------------------------------------------------------------------------------------------");
			//创建路径 
			string upLoadPath = Server.MapPath("~/log/");
			if (!System.IO.Directory.Exists(upLoadPath))
			{
				System.IO.Directory.CreateDirectory(upLoadPath);
			}
			//创建文件 写入错误 
			System.IO.File.AppendAllText(upLoadPath + DateTime.Now.ToString("yyyy.MM.dd") + ".log", str.ToString(), System.Text.Encoding.UTF8);
			//处理完及时清理异常 
			Server.ClearError();
			//跳转至出错页面 
			Response.Redirect("~/Resources/error.html");
		} 
	}
}
