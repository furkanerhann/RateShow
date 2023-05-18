using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        public string conString;
        List<Show> shows = null;
        private int operationid = 0;
        private int selectedId;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            getData();
            set(0);
        }
        private void set(int id)
        {
            if (id == 0)
            {
                tbox_showname.Visible = false;
                tbox_url.Visible = false;
                tbox_genre.Visible = false;
                tbox_topic.Visible = false;
                tbox_language.Visible = false;
                tbox_releasedate.Visible = false;
                tbox_watcheddate.Visible = false;
                tbox_rate.Visible = false;
                btn_operations.Visible = false;
                tbox_showname.Text = "";
                tbox_url.Text = "";
                tbox_genre.Text = "";
                tbox_topic.Text = "";
                tbox_language.Text = "";
                tbox_releasedate.Text = "";
                tbox_watcheddate.Text = "";
                tbox_rate.Text = "";
                tbox_choose.Text = "";
                cbox_sort.SelectedIndex = 0;
            }
            else if (id == 1)
            {
                tbox_showname.Visible = true;
                tbox_url.Visible = true;
                tbox_genre.Visible = true;
                tbox_topic.Visible = true;
                tbox_language.Visible = true;
                tbox_releasedate.Visible = true;
                tbox_watcheddate.Visible = true;
                tbox_rate.Visible = true;
                btn_operations.Visible = true;
                tbox_showname.Text = "";
                tbox_url.Text = "";
                tbox_genre.Text = "";
                tbox_topic.Text = "";
                tbox_language.Text = "";
                tbox_releasedate.Text = "";
                tbox_watcheddate.Text = "";
                tbox_rate.Text = "";
                btn_operations.Text = "Add New";
                operationid = 1;
            }
            else if (id == 2)
            {
                tbox_showname.Visible = true;
                tbox_url.Visible = true;
                tbox_genre.Visible = true;
                tbox_topic.Visible = true;
                tbox_language.Visible = true;
                tbox_releasedate.Visible = true;
                tbox_watcheddate.Visible = true;
                tbox_rate.Visible = true;
                btn_operations.Visible = true;
                btn_operations.Text = "Update";
                operationid = 2;
            }
        }
        private void getData(string name = "", string genre = "", string topic = "", string language = "", int sortby = 0)
        {
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdString = @"Select * From Shows";
                if (!(name == "" && genre == "" && topic == "" && language == ""))
                {
                    cmdString += " WHERE ";
                    int addand = 0;
                    if (name != "")
                    {
                        cmdString += "Show_Name LIKE '%" + name + "%'";
                        addand = 1;
                    }
                    if (genre != "")
                    {
                        if (addand == 1)
                        {
                            cmdString += " AND ";
                        }
                        cmdString += "Genre LIKE '%" + genre + "%' ";
                        addand = 1;
                    }
                    if (topic != "")
                    {
                        if (addand == 1)
                        {
                            cmdString += " AND ";
                        }
                        cmdString += "Topic LIKE '%" + topic + "%' ";
                        addand = 1;
                    }
                    if (language != "")
                    {
                        if (addand == 1)
                        {
                            cmdString += " AND ";
                        }
                        cmdString += "Language LIKE '%" + language + "%' ";
                        addand = 1;
                    }
                }
                if (sortby == 0)
                {
                    cmdString += " ORDER BY Watched_Date DESC";
                }
                else if (sortby == 1)
                {
                    cmdString += " ORDER BY Watched_Date ASC";
                }
                else if (sortby == 2)
                {
                    cmdString += " ORDER BY Rate DESC";
                }
                else if (sortby == 3)
                {
                    cmdString += " ORDER BY Rate ASC";
                }
                else if (sortby == 4)
                {
                    cmdString += " ORDER BY Release_Date DESC";
                }
                else if (sortby == 5)
                {
                    cmdString += " ORDER BY Release_Date ASC";
                }
                else if (sortby == 6)
                {
                    cmdString += " ORDER BY Show_Name ASC";
                }
                else if (sortby == 7)
                {
                    cmdString += " ORDER BY Show_Name DESC";
                }
                cmdString += ";";
                SqlCommand cmd = new SqlCommand(cmdString, con);
                var dataReader = cmd.ExecuteReader();
                shows = Getlist<Show>(dataReader);
                con.Close();
            }
            if (shows != null)
            {
                if (ShowListPanel.Controls.Count > 0)
                {
                    ShowListPanel.Controls.Clear();
                }
                ListItem[] showlist = new ListItem[shows.Count];
                for (int i = 0; i < showlist.Length; i++)
                {
                    showlist[i] = new ListItem();
                    showlist[i].Header = (i + 1).ToString() + ". " + shows[i].Show_Name + " (" + shows[i].Release_Date.Substring(0, 4) + ")";
                    showlist[i].Info = shows[i].Genre + ", " + shows[i].Topic + " ● " + shows[i].Language;
                    showlist[i].Watched = "Watched: " + shows[i].Watched_Date;
                    showlist[i].Rate = shows[i].Rate.ToString();
                    Image banner = readImage(shows[i].Img_Url);
                    showlist[i].Banner = banner;
                    ShowListPanel.Controls.Add(showlist[i]);
                }
            }
        }
        private List<T> Getlist<T>(IDataReader reader)
        {
            List<T> list = new List<T>();
            while (reader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                }
                list.Add(obj);
            }
            return list;
        }
        private Image readImage(string url)
        {
            Image image;
            try
            {
                var request = WebRequest.Create(url);
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        image = Bitmap.FromStream(stream);

                    }
                }
            }
            catch
            {
                var request = WebRequest.Create(@"https://reactnativecode.com/wp-content/uploads/2018/01/Error_Img.png");
                using (var response = request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        image = Bitmap.FromStream(stream);

                    }
                }
            }
            return image;
        }

        private Point mouseDownLocation;

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

        private void btn_new_Click(object sender, EventArgs e)
        {
            set(1);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedId != 0)
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    try
                    {
                        string comstring = "DELETE FROM Shows WHERE Id = " + selectedId + ";";
                        con.Open();
                        SqlCommand com = new SqlCommand(comstring, con);
                        com.ExecuteNonQuery();
                        set(0);
                        getData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred!\nError: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please set a show first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string name = tbox_searchname.Text;
            string genre = tbox_searchgenre.Text;
            string topic = tbox_searchtopic.Text;
            string language = tbox_searchlanguage.Text;
            int sort = cbox_sort.SelectedIndex;
            getData(name, genre, topic, language, sort);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Login newform = new Login();
            newform.Show();
            this.Hide();
        }

        private void btn_operations_Click(object sender, EventArgs e)
        {
            if (operationid == 1)
            {
                try
                {
                    string name = tbox_showname.Text;
                    string url = tbox_url.Text;
                    string genre = tbox_genre.Text;
                    string topic = tbox_topic.Text;
                    string language = tbox_language.Text;
                    string release_date = tbox_releasedate.Text;
                    string watched_date = tbox_watcheddate.Text;
                    string ratetext = tbox_rate.Text;
                    if (name == "" || url == "" || genre == "" || topic == "" || language == "" || release_date == "" || watched_date == "" || ratetext == "")
                    {
                        MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (release_date.Substring(4, 1) != "." || release_date.Substring(7, 1) != "." || watched_date.Substring(4, 1) != "." || watched_date.Substring(7, 1) != ".")
                    {
                        MessageBox.Show("Please fill in the date sections duly. (Example: 2020.01.01)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        decimal rate = Convert.ToDecimal(ratetext.Replace(".", ","));
                        string comstring = "INSERT INTO Shows (Show_Name, Img_Url, Genre, Topic, Language, Release_Date, Watched_Date, Rate) VALUES(@sn, @url, @g, @t, @l, @rd, @wd, @r);";
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand com = new SqlCommand(comstring, con))
                                {
                                    com.Parameters.Add("@sn", SqlDbType.NVarChar).Value = name;
                                    com.Parameters.Add("@url", SqlDbType.NVarChar).Value = url;
                                    com.Parameters.Add("@g", SqlDbType.NVarChar).Value = genre;
                                    com.Parameters.Add("@t", SqlDbType.NVarChar).Value = topic;
                                    com.Parameters.Add("@l", SqlDbType.NVarChar).Value = language;
                                    com.Parameters.Add("@rd", SqlDbType.NVarChar).Value = release_date;
                                    com.Parameters.Add("@wd", SqlDbType.NVarChar).Value = watched_date;
                                    com.Parameters.Add("@r", SqlDbType.Decimal).Value = rate;
                                    int rowsAdded = com.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        set(0);
                                        getData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("An error occurred while adding data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while loading data!\nError: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (operationid == 2)
            {
                try
                {
                    string name = tbox_showname.Text;
                    string url = tbox_url.Text;
                    string genre = tbox_genre.Text;
                    string topic = tbox_topic.Text;
                    string language = tbox_language.Text;
                    string release_date = tbox_releasedate.Text;
                    string watched_date = tbox_watcheddate.Text;
                    string ratetext = tbox_rate.Text;
                    if (name == "" || url == "" || genre == "" || topic == "" || language == "" || release_date == "" || watched_date == "" || ratetext == "")
                    {
                        MessageBox.Show("Please fill in all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (release_date.Substring(4, 1) != "." || release_date.Substring(7, 1) != "." || watched_date.Substring(4, 1) != "." || watched_date.Substring(7, 1) != ".")
                    {
                        MessageBox.Show("Please fill in the date sections duly. (Example: 2020.01.01)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string comstring = "UPDATE Shows SET Show_Name = @sn, Img_Url = @url, Genre = @g, Topic = @t, Language = @l, Release_Date = @rd, Watched_Date = @wd, Rate = @r WHERE Id = " + selectedId + ";";
                        decimal rate = Convert.ToDecimal(ratetext.Replace(".", ","));
                        using (SqlConnection con = new SqlConnection(conString))
                        {
                            try
                            {
                                con.Open();
                                using (SqlCommand com = new SqlCommand(comstring, con))
                                {
                                    com.Parameters.Add("@sn", SqlDbType.NVarChar).Value = name;
                                    com.Parameters.Add("@url", SqlDbType.NVarChar).Value = url;
                                    com.Parameters.Add("@g", SqlDbType.NVarChar).Value = genre;
                                    com.Parameters.Add("@t", SqlDbType.NVarChar).Value = topic;
                                    com.Parameters.Add("@l", SqlDbType.NVarChar).Value = language;
                                    com.Parameters.Add("@rd", SqlDbType.NVarChar).Value = release_date;
                                    com.Parameters.Add("@wd", SqlDbType.NVarChar).Value = watched_date;
                                    com.Parameters.Add("@r", SqlDbType.Decimal).Value = rate;
                                    int rowsAdded = com.ExecuteNonQuery();
                                    if (rowsAdded > 0)
                                    {
                                        set(0);
                                        getData();
                                    }
                                    else
                                    {
                                        MessageBox.Show("An error occurred while updating data!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred while loading data!\nError: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            string choosetext = tbox_choose.Text;
            int choosen = Convert.ToInt32(tbox_choose.Text) - 1;
            if (choosetext != "" && choosen >= 0 && choosen < shows.Count)
            {
                selectedId = shows[choosen].Id;
                tbox_showname.Text = shows[choosen].Show_Name;
                tbox_url.Text = shows[choosen].Img_Url;
                tbox_genre.Text = shows[choosen].Genre;
                tbox_topic.Text = shows[choosen].Topic;
                tbox_language.Text = shows[choosen].Language;
                tbox_releasedate.Text = shows[choosen].Release_Date;
                tbox_watcheddate.Text = shows[choosen].Watched_Date;
                tbox_rate.Text = shows[choosen].Rate.ToString();
                set(2);
            }
        }
    }
}
