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

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private Point mouseDownLocation;
        private int loginprocess = 1;
        private int newprocess = 1;
        private void FormMenuPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mouseDownLocation.X;
                this.Top = e.Y + this.Top - mouseDownLocation.Y;
            }
        }

        private void FormMenuPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLocation = e.Location;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (loginprocess == 1)
            {
                string server = tbox_server.Text;
                string database = tbox_database.Text;
                string username = tbox_username.Text;
                string password = tbox_password.Text;
                if (server != "" && database != "" && username != "" && password != "")
                {
                    string conString = @"Data Source= " + server + "; Initial Catalog= " + database + "; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con = new SqlConnection(conString);
                    try
                    {
                        con.Open();
                        con.Close();
                        MainMenu newform = new MainMenu();
                        newform.conString = conString;
                        newform.Show();
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("An error was encountered while establishing the connection!\r\nPlease make sure the information you entered is correct and your sql service is started.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (loginprocess == 2)
            {
                string server = tbox_server.Text;
                string database = tbox_database.Text;
                string username = tbox_username.Text;
                string password = tbox_password.Text;
                if (server != "" && database != "" && username != "" && password != "")
                {
                    string conString1 = @"Data Source= " + server + "; Initial Catalog= master; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con1 = new SqlConnection(conString1);
                    string comString1 = "CREATE DATABASE " + database + ";";
                    SqlCommand com1 = new SqlCommand(comString1, con1);
                    string conString2 = @"Data Source= " + server + "; Initial Catalog= " + database + "; User ID = " + username + "; Password = " + password + ";";
                    SqlConnection con2 = new SqlConnection(conString2);
                    string comString2 = "CREATE TABLE Shows(Id int IDENTITY(1000,1) PRIMARY KEY, Show_Name varchar(255) NOT NULL, Img_Url varchar(255) NOT NULL, Genre varchar(255) NOT NULL, Topic varchar(255) NOT NULL, Language varchar(255) NOT NULL, Release_Date varchar(255) NOT NULL, Watched_Date varchar(255) NOT NULL, Rate decimal(18,2) NOT NULL);";
                    SqlCommand com2 = new SqlCommand(comString2, con2);
                    try
                    {
                        con1.Open();
                        com1.ExecuteNonQuery();
                        con1.Close();
                        con2.Open();
                        com2.ExecuteNonQuery();
                        con2.Close();
                        MessageBox.Show("Your database has been successfully created! You can login now.", "Database Creation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        btn_newdatabase.PerformClick();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error was encountered while creating the database!\r\nError: " + ex.ToString(), "Database Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_newdatabase_Click(object sender, EventArgs e)
        {
            if (newprocess == 1)
            {
                btn_login.Text = "Create";
                btn_newdatabase.Text = "Back To Login Screen";
                lbl_maintext.Text = "This application has been created for you to rate the TV series and movies you watch.\r\nPress the button below to return to the login screen.";
                loginprocess = 2;
                newprocess = 2;
            }
            else if (newprocess == 2)
            {
                btn_login.Text = "Connect";
                btn_newdatabase.Text = "Create New Database";
                lbl_maintext.Text = "This application has been created for you to rate the TV series and movies you watch.\r\nIf you are using it for the first time, please click the button below to create a new database.";
                loginprocess = 1;
                newprocess = 1;
            }
        }
    }
}
