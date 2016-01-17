using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb_3
{
    /// <summary>
    /// Summary description for AddingNumbers
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AddingThreeNumbers : System.Web.Services.WebService
    {

        [WebMethod]
        public string AddThreeNumbers(int x, int y, int d)
        {
            int res = x + y + d;
            return res.ToString();
        }
    }
}
