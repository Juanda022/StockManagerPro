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
    public partial class Register : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionbd"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Register_Click(object sender, EventArgs e)
        {
            User objUsers = new User();
            objUsers.UserID = int.Parse(txt_user.Text);
            objUsers.UserPassword = Encrypt.GetSHA256(txt_password.Text);
            objUsers.UserRole = txt_role.Text;

            string querie = "INSERT INTO [dbo].[Users] VALUES(@userID, @userPassword, @userRole)";

            SqlCommand comand = new SqlCommand(querie);
            comand.Parameters.AddWithValue("@userID", objUsers.UserID);
            comand.Parameters.AddWithValue("@userPassword", objUsers.UserPassword);
            comand.Parameters.AddWithValue("@userRole",objUsers.UserRole);
            comand.Connection = connection;
            connection.Open();
            comand.ExecuteNonQuery();
            connection.Close();
            comand.Dispose();
            Response.Write("<script>alert('Registro insertado...!!!');</script>");
        }
    }
}