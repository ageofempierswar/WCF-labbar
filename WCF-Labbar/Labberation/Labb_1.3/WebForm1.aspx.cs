using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Labb_1._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            var client  = new AddingThreeNumbers.AddingThreeNumbersSoapClient();
            Label1.Text = client.AddingNumbers(1, 1, 1);
        }
    }
}