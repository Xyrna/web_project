using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_project
{
    public partial class Login : System.Web.UI.Page
    { 
        SqlConnection conn = new SqlConnection("Server=DESKTOP-2QKN505\\SQLEXPRESS; Database= Northwind; Integrated Security=true;");
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            //conn.Open();
            //string query = "SELECT * FROM Users WHERE username = '" + txtUsernameL.Text + "' AND password = '" + txtPasswordL.Text + "'";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //SqlDataReader dr = cmd.ExecuteReader();

            //if (dr.Read())
            //{
            //    string script = "alert(\"Login Successful!\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(),
            //                          "ServerControlScript", script, true);
            //}
            //else
            //{
            //    string script = "alert(\"Login Unsuccessful. Please try again.\");";
            //    ScriptManager.RegisterStartupScript(this, GetType(),
            //                          "ServerControlScript", script, true);
            //}

            //txtUsernameL.Text = "";
            //txtPasswordL.Text = "";
            //txtUsernameL.Focus();

            conn.Open();

            SqlCommand cmd = new SqlCommand("ProjectGetUser", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", txtUsernameL.Text);
            cmd.Parameters.AddWithValue("@Password", txtPasswordL.Text);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            conn.Close();

            if (Convert.ToInt32(ds.Tables[0].Rows.Count) == 0)
            {
                string script = "alert(\"Login Unsuccessful. Please try again.\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                

            }
            else
            {
                string script = "alert(\"Login Successful!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
            }

            txtUsernameL.Text = "";
            txtPasswordL.Text = "";
            txtUsernameL.Focus();
        }

        protected void btnToRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registration.aspx");

        }
    }
}