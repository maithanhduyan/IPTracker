using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections;

namespace IPService.IP
{
    public class IPStorage
    {
        #region Variable
        private ArrayList listIP_;
        #endregion

        #region Save IP
        public Boolean saveIP(ClientIP ip)
        {
            int result = this.listIP_.Add(ip);
            if (result == 1)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Constructor
        public IPStorage()
        {
            this.listIP_ = new ArrayList();
            this.listIP_.Add("192.168.1.1");
            Console.WriteLine("IP storage...");
        }
        #endregion

        #region Properties
        public ArrayList ListIP
        {
            get { return listIP_; }
            set
            {
                if (listIP_ != value)
                    listIP_ = value;
            }
        }
        #endregion
    }
}
