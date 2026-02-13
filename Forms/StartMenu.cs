using ManagmentApplication.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagmentApplication.Helper;
using System.Data.SqlClient;
using System.Drawing.Text;
using ManagmentApplication.Forms.AdminSite;

namespace ManagmentApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //GenerateRandomCustomers.GenerateRandom();
        }
        private static string connectionString = "Server=DESKTOP-N511VU1\\SQLEXPRESS;Database=EsZamanliSiparisYonetimi;Integrated Security=true";
        private void UserEntrance_click(object sender, EventArgs e)
        {
            string userName = UserNameTF.Text;
            string password = UserPasswordTF.Text;

            string query = "SELECT CustomerID, CustomerName FROM Customers WHERE CustomerName = @username AND CustomerPassword = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection)) 
                    { 
                        command.Parameters.AddWithValue("username", userName);
                        command.Parameters.AddWithValue("password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                UserInfo.LoggedInUserID = reader.GetInt32(0);
                                UserInfo.LoggedInUserName = reader.GetString(1); 

                                UserForm userForm = new UserForm();
                                userForm.Show();

                            }
                            else { MessageBox.Show("Kullanıcı adı veya şifre hatalı!"); }
                        }
                        
                    }
                }
                catch(Exception ex) { MessageBox.Show($"Hata oluştu: {ex.Message}"); }
            }
        }

        private void AdminEntrance_click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        

        private void logPanelButton_Click(object sender, EventArgs e)
        {
            
            LogPanel logPanelForm = new LogPanel();

            
            logPanelForm.Show();
        }
    }
}
