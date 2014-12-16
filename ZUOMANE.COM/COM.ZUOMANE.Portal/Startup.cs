using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(COM.ZUOMANE.Portal.Startup))]
namespace COM.ZUOMANE.Portal
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureAuth(app);
		}
	}
}
