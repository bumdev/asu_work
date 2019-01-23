using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace kipia_web_application
{
    public partial class FabonentDet2018 : ULPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request["id"] != null)
                {
                    FAbonDet20181.OrderID = Utilities.ConvertToInt(Request["id"]);
                    FAbonDet20181.Bind();
                }
            }
        }
    }
}