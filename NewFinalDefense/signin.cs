using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;



namespace NewFinalDefense
{
    public partial class signin : Form
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;
        static SqlDataReader reader = null;

        public signin()
        {
            InitializeComponent();
            Database_Connection();
        }
        private void Database_Connection()
        {
            string url = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\reivh\source\repos\NewFinalDefense\NewFinalDefense\Database1.mdf;
                        Integrated Security=True";
            conn = new SqlConnection(url);

        }
        private void LogIn_Click(object sender, EventArgs e)
        {
            string usernamee = username.Text;
            string passWord = password.Text;

            if (String.IsNullOrEmpty(usernamee) || String.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("username or password should not be blank");
                
            }

            else
            {
                try
                {
                    string query = "SELECT username,password FROM SignIn WHERE username = '" + usernamee + "' " +
                        "AND password = '" + passWord + "' ";
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();

                    if (!reader.Read())
                    {
                        MessageBox.Show("Invalid login, username or password incorrect");
                        
                        

                    }
                    else if (usernamee == "cashier123" && passWord == "cashier321")
                    {
                        MessageBox.Show("Log in succesfully!\n Welcome Cashier!");
                        CDashboard cashierDB = new CDashboard();
                        cashierDB.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Log in succesfully!\nWelcome Admin!");
                        dashboard db = new dashboard();
                        db.Show();
                        this.Hide();




                    }
                    conn.Close();

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}



