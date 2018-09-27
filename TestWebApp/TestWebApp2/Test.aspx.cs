using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApp2
{
    public partial class Test : System.Web.UI.Page
    {
        public int ClickCount = 1;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                TxtCount.Text = "0";
                //Response.Write("<script>alert('No Post back')</script>");
            }
            BAL ba = new BAL();
            GridView1.DataSource = ba.select();
            GridView1.DataBind();

            //gvData.DataSource = ba.select();
            //gvData.DataBind();
           

        }
        protected void btnSubmitClick(object sender,EventArgs e)
        {
            //Response.Write("<script>alert('Data inserted successfully')</script>");
            
            //if (ViewState["Clicks"] != null)
            //{
            //    ViewState["Clicks"] = Convert.ToInt32(ViewState["Clicks"]) + ClickCount;
            //}
            //else
            //{
            //    ViewState["Clicks"] = ClickCount.ToString();
            //}

            //TxtCount.Text = ViewState["Clicks"].ToString();
        }

    }
}