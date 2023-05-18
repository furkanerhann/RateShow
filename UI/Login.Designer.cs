namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            FormPanel = new TableLayoutPanel();
            FormMenuPanel = new TableLayoutPanel();
            btn_minimize = new Button();
            btn_maximize = new Button();
            btn_exit = new Button();
            lbl_rateshow = new Label();
            MainPanel = new TableLayoutPanel();
            RightPanel = new TableLayoutPanel();
            tbox_server = new TextBox();
            tbox_database = new TextBox();
            tbox_username = new TextBox();
            tbox_password = new TextBox();
            btn_login = new Button();
            LeftPanel = new TableLayoutPanel();
            lbl_maintext = new Label();
            ButonPanel = new TableLayoutPanel();
            btn_newdatabase = new Button();
            FormPanel.SuspendLayout();
            FormMenuPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            RightPanel.SuspendLayout();
            LeftPanel.SuspendLayout();
            ButonPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FormPanel
            // 
            FormPanel.ColumnCount = 1;
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FormPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            FormPanel.Controls.Add(FormMenuPanel, 0, 0);
            FormPanel.Controls.Add(MainPanel, 0, 1);
            FormPanel.Dock = DockStyle.Fill;
            FormPanel.Location = new Point(0, 0);
            FormPanel.Name = "FormPanel";
            FormPanel.RowCount = 2;
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            FormPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FormPanel.Size = new Size(1440, 810);
            FormPanel.TabIndex = 0;
            // 
            // FormMenuPanel
            // 
            FormMenuPanel.ColumnCount = 5;
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            FormMenuPanel.Controls.Add(btn_minimize, 2, 0);
            FormMenuPanel.Controls.Add(btn_maximize, 3, 0);
            FormMenuPanel.Controls.Add(btn_exit, 4, 0);
            FormMenuPanel.Controls.Add(lbl_rateshow, 1, 0);
            FormMenuPanel.Dock = DockStyle.Fill;
            FormMenuPanel.Location = new Point(3, 3);
            FormMenuPanel.Name = "FormMenuPanel";
            FormMenuPanel.RowCount = 1;
            FormMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            FormMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            FormMenuPanel.Size = new Size(1434, 54);
            FormMenuPanel.TabIndex = 0;
            FormMenuPanel.MouseDown += FormMenuPanel_MouseDown;
            FormMenuPanel.MouseMove += FormMenuPanel_MouseMove;
            // 
            // btn_minimize
            // 
            btn_minimize.Dock = DockStyle.Fill;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Image = (Image)resources.GetObject("btn_minimize.Image");
            btn_minimize.Location = new Point(1257, 3);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(54, 48);
            btn_minimize.TabIndex = 100;
            btn_minimize.TabStop = false;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Dock = DockStyle.Fill;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.Image = (Image)resources.GetObject("btn_maximize.Image");
            btn_maximize.Location = new Point(1317, 3);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(54, 48);
            btn_maximize.TabIndex = 101;
            btn_maximize.TabStop = false;
            btn_maximize.UseVisualStyleBackColor = true;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // btn_exit
            // 
            btn_exit.Dock = DockStyle.Fill;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.Location = new Point(1377, 3);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(54, 48);
            btn_exit.TabIndex = 102;
            btn_exit.TabStop = false;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // lbl_rateshow
            // 
            lbl_rateshow.Anchor = AnchorStyles.Bottom;
            lbl_rateshow.AutoSize = true;
            lbl_rateshow.Font = new Font("Ravie", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_rateshow.ForeColor = Color.OrangeRed;
            lbl_rateshow.Location = new Point(611, 18);
            lbl_rateshow.Name = "lbl_rateshow";
            lbl_rateshow.Size = new Size(211, 36);
            lbl_rateshow.TabIndex = 103;
            lbl_rateshow.Text = "Rate Show";
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 2;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            MainPanel.Controls.Add(RightPanel, 1, 0);
            MainPanel.Controls.Add(LeftPanel, 0, 0);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 63);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 1;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.Size = new Size(1434, 744);
            MainPanel.TabIndex = 1;
            // 
            // RightPanel
            // 
            RightPanel.ColumnCount = 3;
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            RightPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            RightPanel.Controls.Add(tbox_server, 1, 1);
            RightPanel.Controls.Add(tbox_database, 1, 3);
            RightPanel.Controls.Add(tbox_username, 1, 5);
            RightPanel.Controls.Add(tbox_password, 1, 7);
            RightPanel.Controls.Add(btn_login, 1, 9);
            RightPanel.Dock = DockStyle.Fill;
            RightPanel.Location = new Point(863, 3);
            RightPanel.Name = "RightPanel";
            RightPanel.RowCount = 11;
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            RightPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightPanel.Size = new Size(568, 738);
            RightPanel.TabIndex = 0;
            // 
            // tbox_server
            // 
            tbox_server.BackColor = Color.White;
            tbox_server.Dock = DockStyle.Fill;
            tbox_server.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_server.ForeColor = Color.Black;
            tbox_server.Location = new Point(87, 212);
            tbox_server.Name = "tbox_server";
            tbox_server.Size = new Size(394, 35);
            tbox_server.TabIndex = 0;
            tbox_server.Text = "localhost";
            // 
            // tbox_database
            // 
            tbox_database.BackColor = Color.White;
            tbox_database.Dock = DockStyle.Fill;
            tbox_database.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_database.ForeColor = Color.Black;
            tbox_database.Location = new Point(87, 272);
            tbox_database.Name = "tbox_database";
            tbox_database.PlaceholderText = "database";
            tbox_database.Size = new Size(394, 35);
            tbox_database.TabIndex = 1;
            // 
            // tbox_username
            // 
            tbox_username.BackColor = Color.White;
            tbox_username.Dock = DockStyle.Fill;
            tbox_username.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_username.ForeColor = Color.Black;
            tbox_username.Location = new Point(87, 332);
            tbox_username.Name = "tbox_username";
            tbox_username.PlaceholderText = "username";
            tbox_username.Size = new Size(394, 35);
            tbox_username.TabIndex = 2;
            // 
            // tbox_password
            // 
            tbox_password.BackColor = Color.White;
            tbox_password.Dock = DockStyle.Fill;
            tbox_password.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_password.ForeColor = Color.Black;
            tbox_password.Location = new Point(87, 392);
            tbox_password.Name = "tbox_password";
            tbox_password.PlaceholderText = "password";
            tbox_password.Size = new Size(394, 35);
            tbox_password.TabIndex = 3;
            tbox_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(87, 452);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(394, 74);
            btn_login.TabIndex = 4;
            btn_login.Text = "Connect";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // LeftPanel
            // 
            LeftPanel.ColumnCount = 3;
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            LeftPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LeftPanel.Controls.Add(lbl_maintext, 1, 1);
            LeftPanel.Controls.Add(ButonPanel, 1, 3);
            LeftPanel.Dock = DockStyle.Fill;
            LeftPanel.Location = new Point(3, 3);
            LeftPanel.Name = "LeftPanel";
            LeftPanel.RowCount = 5;
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LeftPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            LeftPanel.Size = new Size(854, 738);
            LeftPanel.TabIndex = 1;
            // 
            // lbl_maintext
            // 
            lbl_maintext.Anchor = AnchorStyles.Top;
            lbl_maintext.AutoSize = true;
            lbl_maintext.Font = new Font("Perpetua Titling MT", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_maintext.ForeColor = Color.DimGray;
            lbl_maintext.Location = new Point(180, 209);
            lbl_maintext.Name = "lbl_maintext";
            lbl_maintext.Size = new Size(492, 138);
            lbl_maintext.TabIndex = 0;
            lbl_maintext.Text = "This application has been created for you to rate the TV series and movies you watch.\r\nIf you are using it for the first time, please click the button below to create a new database.";
            lbl_maintext.TextAlign = ContentAlignment.TopCenter;
            // 
            // ButonPanel
            // 
            ButonPanel.ColumnCount = 3;
            ButonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            ButonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ButonPanel.Controls.Add(btn_newdatabase, 1, 0);
            ButonPanel.Dock = DockStyle.Fill;
            ButonPanel.Location = new Point(173, 452);
            ButonPanel.Name = "ButonPanel";
            ButonPanel.RowCount = 1;
            ButonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButonPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            ButonPanel.Size = new Size(506, 74);
            ButonPanel.TabIndex = 1;
            // 
            // btn_newdatabase
            // 
            btn_newdatabase.Dock = DockStyle.Fill;
            btn_newdatabase.FlatAppearance.BorderSize = 0;
            btn_newdatabase.FlatStyle = FlatStyle.Flat;
            btn_newdatabase.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_newdatabase.Image = (Image)resources.GetObject("btn_newdatabase.Image");
            btn_newdatabase.ImageAlign = ContentAlignment.MiddleLeft;
            btn_newdatabase.Location = new Point(56, 3);
            btn_newdatabase.Name = "btn_newdatabase";
            btn_newdatabase.Size = new Size(394, 68);
            btn_newdatabase.TabIndex = 1;
            btn_newdatabase.Text = "Create New Database";
            btn_newdatabase.TextAlign = ContentAlignment.MiddleRight;
            btn_newdatabase.UseVisualStyleBackColor = true;
            btn_newdatabase.Click += btn_newdatabase_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1440, 810);
            Controls.Add(FormPanel);
            ForeColor = Color.FromArgb(252, 196, 25);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            FormPanel.ResumeLayout(false);
            FormMenuPanel.ResumeLayout(false);
            FormMenuPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            RightPanel.ResumeLayout(false);
            RightPanel.PerformLayout();
            LeftPanel.ResumeLayout(false);
            LeftPanel.PerformLayout();
            ButonPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private TableLayoutPanel FormMenuPanel;
        private Button btn_minimize;
        private Button btn_maximize;
        private Button btn_exit;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel RightPanel;
        private TextBox tbox_server;
        private TextBox tbox_database;
        private TextBox tbox_username;
        private TextBox tbox_password;
        private Button btn_login;
        private Label lbl_maintext;
        private Button btn_newdatabase;
        private Label lbl_rateshow;
        private TableLayoutPanel LeftPanel;
        private TableLayoutPanel ButonPanel;
    }
}