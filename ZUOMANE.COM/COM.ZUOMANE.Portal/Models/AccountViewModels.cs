using System.ComponentModel.DataAnnotations;

namespace COM.ZUOMANE.Portal.Models
{
	public class ExternalLoginConfirmationViewModel
	{
		[Required]
		[Display(Name = "用户名")]
		public string UserName { get; set; }
	}

	public class ManageUserViewModel
	{
		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "当前密码")]
		public string OldPassword { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "长度必须介于 {0} 和 {2} 之间.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "新密码")]
		public string NewPassword { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "确认新密码")]
		[Compare("NewPassword", ErrorMessage = "新密码和确认新密码不匹配.")]
		public string ConfirmPassword { get; set; }
	}

	public class LoginViewModel
	{
		[Required]
		[Display(Name = "用户名")]
		public string UserName { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "密码")]
		public string Password { get; set; }

		[Display(Name = "记住登陆状态?")]
		public bool RememberMe { get; set; }
	}

	public class RegisterViewModel
	{
		[Required]
		[Display(Name = "用户名")]
		public string UserName { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "长度必须介于 {0} 和 {2} 之间.", MinimumLength = 6)]
		[DataType(DataType.Password)]
		[Display(Name = "密码")]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "确认密码")]
		[Compare("Password", ErrorMessage = "密码和确认密码不匹配.")]
		public string ConfirmPassword { get; set; }
	}
}
