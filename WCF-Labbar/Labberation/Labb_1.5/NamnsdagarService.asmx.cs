using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
namespace Labb_1._5
{
    /// <summary>
    /// Summary description for NamnsdagarService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class NamnsdagarService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetNameForDate(string input)
        {
            var array = File.ReadAllLines(@"..\Namnsdagar.txt");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(input))
                {
                    var newArray = array[i].Split(' ');
                    return input + " har namnsdag " + newArray[0] + "/" + newArray[1];
                }
            }

            return array[0];
        }
    }
}
