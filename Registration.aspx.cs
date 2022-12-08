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
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection("Server=DESKTOP-2QKN505\\SQLEXPRESS; Database=Northwind; Integrated Security=true;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text != "" && txtUsername.Text != "" && txtRptPassword.Text != "")
                {
                    if (txtPassword.Text == txtRptPassword.Text)
                    {

                        conn.Open();

                        SqlCommand cmd = new SqlCommand("Register", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                        cmd.Parameters.AddWithValue("@Name", txtName.Text);
                        cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Out", txtPassword.Text);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        conn.Close();
                        if (Convert.ToInt32(ds.Tables[0].Rows[0][0]) == 0)
                        {
                            ClientScript.RegisterStartupScript(Page.GetType(), "Message", "alert('Successful Registation!');window.location='Login.aspx';", true);
                        }
                        else
                        {
                            string script = "alert(\"This user exists! Please try again.\");";
                            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                        }


                    }
                    else
                    {
                        string script = "alert(\"Passwords are not matching! Try again.\");";
                        ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                    }

                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtRptPassword.Text = "";

                    txtUsername.Focus();
                }
                else
                {
                    string script = "alert(\"Empty field! Please fill.\");";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                }

            }
            catch { }
            finally { }
        }

        protected void btnToLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }
    }
}