using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Submit_Click(object sender, EventArgs e)
        {

            DataAccess person = new DataAccess();
            person.name = txtName.Text;
            person.a = cbVanilla.Checked;
            person.b = cbChocolate.Checked;
            person.c = cbCookie.Checked;
            person.d = cbPistachio.Checked;
            
            person.insert();
            
            Response.Redirect("navigation.aspx");
        }
    }
}