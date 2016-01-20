using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Labb_1._2.AdditionServiceTwoNumbers;
namespace Labb_1._2
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void AddNumbers_Click(object sender, EventArgs e)
        {
            var client = new AdditionServiceTwoNumbers.AdditionServiceSoapClient();
            Label2.Text = client.AddTwoNumbers(int.Parse(TextBox1.Text), int.Parse(TextBox2.Text));
        }
    }
}