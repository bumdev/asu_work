﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kipia_web_application
{
    public partial class admin_admin : ULMasterPage 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsAdmin())
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}