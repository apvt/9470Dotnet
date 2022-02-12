using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQTOSQL01
{
    public partial class Default : System.Web.UI.Page
    {
        StudentDetailsDataContext db = new StudentDetailsDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridview();
            }
        }

        protected void BindGridview()
        {
            var result = from student in db.StudentDetails
                         select new
                         {
                             Id = student.SId,
                             Name = student.SName,
                             Location = student.Location,
                             Gender = student.Gender,
                             Age = student.Age
                         };
            GridView1.DataSource = result;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("AddNew"))
            {
                TextBox txtname = (TextBox)GridView1.FooterRow.FindControl("txtfName");
                TextBox txtlocation = (TextBox)GridView1.FooterRow.FindControl("txtfLocation");
                TextBox txtgender = (TextBox)GridView1.FooterRow.FindControl("txtfGender");
                TextBox txtage = (TextBox)GridView1.FooterRow.FindControl("txtfAge");
                StudentDetail student = new StudentDetail();
                student.SName = txtname.Text;
                student.Location = txtlocation.Text;
                student.Gender = txtgender.Text;
                student.Age = txtage.Text;
                db.StudentDetails.InsertOnSubmit(student);
                db.SubmitChanges();
                lblresult.ForeColor = Color.Green;
                lblresult.Text = txtname.Text + " details inserted successfully";
                BindGridview();
            }
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindGridview();
        }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindGridview();
        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridview();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int empid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            TextBox txtname = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtName");
            TextBox txtlocation = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtLocation");
            TextBox txtgender = (TextBox)GridView1.Rows[e.RowIndex].FindControl("txtGender");
            TextBox txtage = (TextBox)GridView1.FooterRow.FindControl("txtfAge");
            StudentDetail student = new StudentDetail();
            student = db.StudentDetails.Single(x => x.SId == empid);
            student.SName = txtname.Text;
            student.Location = txtlocation.Text;
            student.Gender = txtgender.Text;
            student.Age = txtage.Text;
            db.SubmitChanges();
            GridView1.EditIndex = -1;
            BindGridview();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = txtname.Text + " details updated successfully";
        }
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int sid = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["Id"].ToString());
            string sname = GridView1.DataKeys[e.RowIndex].Values["Name"].ToString();
            StudentDetail student = new StudentDetail();
            student = db.StudentDetails.Single(x => x.SId == sid);
            db.StudentDetails.DeleteOnSubmit(student);
            db.SubmitChanges();
            BindGridview();
            lblresult.ForeColor = Color.Green;
            lblresult.Text = sname + " details deleted successfully";

        }
    }
}