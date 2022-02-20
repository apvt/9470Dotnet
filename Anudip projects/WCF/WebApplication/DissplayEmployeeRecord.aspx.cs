using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DissplayEmployeeRecord : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DataSet ds = new DataSet();
                MyService1.EmployeeServiceClient client = new MyService1.EmployeeServiceClient();
                ds = client.GetEmployeeRecords();
                grdEmployees.DataSource = ds;
                grdEmployees.DataBind();
            }
        }
    }
}