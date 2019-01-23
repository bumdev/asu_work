﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kipia_web_application
{
    public partial class LogOut : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["name"].Expires = DateTime.Now;
            Response.Cookies["pass"].Expires = DateTime.Now;
            Response.Redirect("Default.aspx");
        }
    }
}