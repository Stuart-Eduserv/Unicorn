﻿using System.Web;
using System.Web.UI;

namespace Unicorn.ControlPanel
{
	public class AccessDenied : IControlPanelControl
	{
		public void Render(HtmlTextWriter writer)
		{
			writer.Write("<h2>Access Denied</h2>");
			writer.Write("<p>You need to <a href=\"/sitecore/admin/login.aspx?ReturnUrl={0}\">sign in to Sitecore as an administrator</a> to use the Unicorn control panel.</p>", HttpUtility.UrlEncode(HttpContext.Current.Request.Url.PathAndQuery));
		}
	}
}