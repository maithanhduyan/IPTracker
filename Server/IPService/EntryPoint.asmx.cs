using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using IPService.IP;

namespace IPService
{
    /// <summary>
    /// Summary description for EntryPoint
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class EntryPoint : System.Web.Services.WebService
    {
        IPStorage storage = new IPStorage();
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public Boolean SetClientIP(String IP)
        {
            if (this.storage.ListIP.Add(IP) > 0)
            {
                return true;
            }
            return false;
        }

        [WebMethod]
        public ArrayList GetIP()
        {
            return this.storage.ListIP;
        }

        [WebMethod]
        public int CountIPList() {
            return this.storage.ListIP.Count;
        }
    }
}
