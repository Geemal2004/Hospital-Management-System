using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using HospitalManagementSystem.BLL;
using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.UI
{
    public partial class frmLogin : Form
    {
        private readonly UserService _userService = new UserService();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password,", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connetionString = System.Configuration.ConfigurationManager.ConnectionStrings["HMS"].ConnectionString;
            string query = "SELECT UserID, Role FROM Users WHERE Username = @Username AND Password = @Password";

            try
            {
                using (SqlConnection conn = new SqlConnection(connetionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        int userId = reader.GetInt32(0);
                        string role = reader.GetString(1);
                        
                        MessageBox.Show($"Login Successful,Welcome,{role}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmMain mainForm = new frmMain(role);
                        mainForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database erroe: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                User user = _userService.Login(username, password);
                if (user != null)
                {
                    MessageBox.Show($"Login Successful, Welcome {user.UserName}! Role:{user.Role}");
                    frmMain mainForm = new frmMain(new UserContext(user));
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }













        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
