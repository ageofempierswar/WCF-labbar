using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Labb_1
{
    /// <summary>
    /// Summary description for WCF_Labbar_Labb1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WCF_Labbar_Labb1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string Weather()
        {
            string[] weather = { "Snow", "Sun", "Rain" };
            var rnd = new Random();
            int nr = rnd.Next(0, 3);
            return weather[nr];
        }
    }
}
