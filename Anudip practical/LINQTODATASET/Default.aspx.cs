using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTODATASET
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }
        protected void BindGridview()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-EHTH26K;Integrated Security=true;Initial Catalog=apoorva"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employeedetails1", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                con.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    var result = from dt in ds.Tables[0].AsEnumerable()
                                 where (dt.Field<string>("EmpName").EndsWith("a"))
                                 select new
                                 {
                                     Name = dt.Field<string>("EmpName"),
                                     Location = dt.Field<string>("Location"),
                                     Gender = dt.Field<string>("Gender"),
                                 };
                    GridView1.DataSource = result;
                    GridView1.DataBind();
                }
            }
        }
    }
}
       