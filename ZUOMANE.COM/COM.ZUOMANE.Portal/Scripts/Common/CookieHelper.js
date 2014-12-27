var HttpCookie = function (name, value, expires, path, domain) {
	if (name)
		this.Name = name;
	if (value)
		this.Value = value;
	if (expires)
		this.Expires = expires;
	if (path)
		this.Path = path;
	if (domain)
		this.Domain = domain;
};

HttpCookie.prototype = {
	Name: '',
	Value: '',
	Expires: '',
	Path: '/',
	Domain: '',
	toCookie: function () {
		var NewCookie = this.Name + '=' + this.Value;
		if (this.Expires)
			NewCookie += (';expires=' + this.Expires);
		if (this.Path)
			NewCookie += (';path=' + this.Path);
		if (this.Domain)
			NewCookie += (';domain=' + this.Domain);
		return NewCookie;
	}
}

var CookieHelper = function () {
};

CookieHelper.ConvertToUTCString = function (hourNumber) {
	if (!hourNumber || hourNumber == 0)
		return null;
	var Timestamp = (new Date().getTime() + (hourNumber * 1000 * 60 * 60));
	return new Date(Timestamp).toUTCString();
};
CookieHelper.Set = function (cookieName, cookieValue, expireHour, path, domain) {
	var HC = new HttpCookie(cookieName, escape(cookieValue), CookieHelper
	.ConvertToUTCString(expireHour), path, domain);
	document.cookie = HC.toCookie();
};
CookieHelper.Get = function (cookieName) {
	var regex = new RegExp(("(^| )" + cookieName + "=([^;]*)(;|$)"));
	var Matchs = document.cookie.match(regex);
	if (Matchs)
		return (Matchs[2]);
	return null;
};

CookieHelper.Delete = function (cookieName, path, domain) {
	if (!CookieHelper.Get(cookieName))
		return;
	var HC = new HttpCookie(cookieName, null, CookieHelper
	.ConvertToUTCString(-100));
	document.cookie = HC.toCookie();
};

//使用示例：
//添加COOKIE，设置COOKIE的值： 
//CookieHelper.Set(cookieName, cookieValue, expireHour, path, domain);
//示例： 
//CookieHelper.Set('cookie_name', 'cookie_value', 1); 
//删除COOKIE CookieHelper.Delete('cookie_name');
//获取COOKIE的值 CookieHelper.Get('cookie_name'); 