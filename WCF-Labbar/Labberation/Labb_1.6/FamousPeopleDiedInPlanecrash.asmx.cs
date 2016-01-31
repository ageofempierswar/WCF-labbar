using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
namespace Labb_1._6
{
    /// <summary>
    /// Summary description for FamousPeopleDiedInPlanecrash
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class FamousPeopleDiedInPlanecrash : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetPersonFromList(string year)
        {
            var peopleList = File.ReadAllLines($"../Resources/FamousPeopleDiedInPlaneCrash.txt");
            var personWhoDied = "";
            foreach (var peopleSplit in peopleList.Select(item => item.Split(';')).Where(peopleSplit => peopleSplit.Contains(year)))
            {
                personWhoDied = peopleSplit[1];
            }
            return personWhoDied;
        }
    }
}
