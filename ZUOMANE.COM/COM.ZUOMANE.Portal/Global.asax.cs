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

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}
