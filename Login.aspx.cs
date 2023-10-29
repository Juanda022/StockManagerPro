using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StockManagerPro
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btn_Login_Click(object sender, EventArgs e)
        {
            User objUsers = new User();
            objUsers.UserID = int.Parse(txt_user.Text);
            objUsers.UserPassword = Encrypt.GetSHA256(txt_password.Text);

            string querie = "SELECT * FROM [dbo].[Users] WHERE [UserID] = @userID AND [UserPassword] = @password";

            SqlCommand comand = new SqlCommand(querie);
            comand.Parameters.AddWithValue("@userID", objUsers.UserID);
            comand.Parameters.AddWithValue("@password", objUsers.UserPassword);
            comand.Connection = connection;
            connection.Open();

            using (SqlDataReader reader = comand.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    Session["user"] = objUsers.UserID;
                    Response.Redirect("~/Inicio.aspx");
                }
                else
                {
                    Response.Write("<script language='JavaScript'>" +
                   "alert('Error en los datos registrados...!!!');" +
                   "</script>");

                    Session["user"] = null;
                    Response.Redirect("~/Login.aspx");
                }
            }
            connection.Close();
        }
    }
}