using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_1
{
    public partial class navigation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess person = new DataAccess();
            person.select();

            lblHello.Text = "Hello, " + person.name;
            lblChoices.Text = "You like, ";

            if(person.a)
            {
                lblChoices.Text += "Vanilla, ";
            }
            else { lblChoices.Text += ""; }

            if(person.b)
            {
                lblChoices.Text += "Chocolate, ";
            }
            else { lblChoices.Text += ""; }

            if(person.c)
            {
                lblChoices.Text += "Cookies 'n Cream, ";
            }
            else { lblChoices.Text += ""; }

            if(person.d)
            {
                lblChoices.Text += "Pistachio, ";
            }
            else { lblChoices.Text += ""; }

            lblChoices.Text += "Ice-Creams!";
        }
    }
}