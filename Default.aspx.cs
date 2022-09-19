using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-3S6LNPA;Initial Catalog=ProgrammingDB;User ID=sa;Password=sa");
            protected void Button1_Click(object sender, EventArgs e)
            {

                con.Open();
                SqlCommand comm = new SqlCommand("Insert into EmployeeInfo_Tab values('" + TextBox2.Text + "','"  +int.Parse(TextBox3.Text) +"','" + double.Parse(TextBox4.Text)+ ,con);
                comm.ExecuteNonQuery();
                con.Close();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Inserted');", true);
                LoadRecord();

            }
            void LoadRecord()
            {
                SqlCommand comm = new SqlCommand("select * from StudentInfo_Tab", con);
                SqlDataAdapter d = new SqlDataAdapter(comm);
                DataTable dt = new DataTable();
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Update EmployeeInfo_Tab set EmployeeName= '" + TextBox2.Text +"' 
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Updated');", true);
            LoadRecord();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand comm = new SqlCommand("Delete EmployeeInfo_Tab where EmployeeName= '" + TextBox2.Text + "';         
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Successfully Deleted');", true);
            LoadRecord();
        }
    }
}