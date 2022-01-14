using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _12jandictonary
{
    public partial class _12jandictonary : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "cs.net");
            dct.Add(2, "vb.net");
            dct.Add(3, "vb.net");
            dct.Add(4, "vb.net");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Response.Write(kvp.Key + " " + kvp.Value);
                Response.Write("<br>");
            }
        }
    }
}
