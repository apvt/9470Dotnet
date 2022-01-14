using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArrayList
{
    public partial class ArrayList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            string str = "apoorva";
            int x = 7;
            DateTime d = DateTime.Parse("8-oct-1985");
            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Response.Write(o);
                Response.Write("<br>");
            }
        }
    }
}
