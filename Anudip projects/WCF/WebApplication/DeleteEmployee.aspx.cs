using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }

        //Bind Grid  
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            MyService1.EmployeeServiceClient client = new MyService1.EmployeeServiceClient();
            ds = client.GetEmployeeRecords();
            grdEmployees.DataSource = ds;
            grdEmployees.DataBind();
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            MyService1.EmployeeServiceClient client = new MyService1.EmployeeServiceClient();

            MyService1.Employee employee = new MyService1.Employee();
            employee.EmpID = txtSearch.Text.Trim();
            string result = client.DeleteRecords(employee);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Deleted Successfully!";
            }
            else
            {
                lblSearchResult.Text = "Employee ID: " + txtSearch.Text.Trim() + "Not Found!";
            }
        }
    }
}