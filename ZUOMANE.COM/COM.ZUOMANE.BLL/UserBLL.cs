using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM.ZUOMANE.BLL
{
	public class UserBLL
	{
		public string[] GetRoles(string Name)
		{
			return new string[] { "admin","gust"};
		}
	}
}
