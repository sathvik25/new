using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebApp2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {          
            
                ViewState["fname"] = txtFname.Text;
                ViewState["lname"] = txtLname.Text;
                txtFname.Text = txtLname.Text = string.Empty;

                Button b = (Button)sender;
                b.Focus();
        }

        protected void btnRestore_Click(object sender, EventArgs e)
        {

            if (ViewState["fname"] != null)
            {
                txtFname.Text = ViewState["fname"].ToString();
                
            }
            if (ViewState["lname"] != null)
            {
                txtLname.Text = ViewState["lname"].ToString();

            }

        }
    }
}