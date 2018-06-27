using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MobileService
{
    /// <summary>
    /// Summary description for Convert
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Convert : System.Web.Services.WebService
    {

        [WebMethod]
        public string InchesToСentimeters(string inches)
        {
            if (double.TryParse(inches, out double _inches))
            {
                if (_inches >= 1.4 && _inches <= 6)
                    return (_inches * 2.54).ToString();
                else return "Error! Value must be >= 1.4 and <= 6!";

            }
            else return "Error! Please input correct value!";
        }

    }
}
