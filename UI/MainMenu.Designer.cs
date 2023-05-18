namespace UI
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            FormPanel = new TableLayoutPanel();
            FormMenuPanel = new TableLayoutPanel();
            btn_minimize = new Button();
            lbl_rateshow = new Label();
            btn_maximize = new Button();
            btn_exit = new Button();
            MainPanel = new TableLayoutPanel();
            ShowListPanel = new FlowLayoutPanel();
            RightMenuPanel = new TableLayoutPanel();
            tbox_genre = new TextBox();
            tbox_watcheddate = new TextBox();
            tbox_releasedate = new TextBox();
            tbox_topic = new TextBox();
            tbox_url = new TextBox();
            tbox_language = new TextBox();
            tbox_rate = new TextBox();
            tbox_showname = new TextBox();
            btn_operations = new Button();
            LeftMenuPanel = new TableLayoutPanel();
            btn_back = new Button();
            btn_search = new Button();
            btn_delete = new Button();
            cbox_sort = new ComboBox();
            tbox_searchname = new TextBox();
            btn_new = new Button();
            tbox_searchlanguage = new TextBox();
            tbox_searchtopic = new TextBox();
            tbox_searchgenre = new TextBox();
            ChoosePanel = new TableLayoutPanel();
            btn_set = new Button();
            tbox_choose = new TextBox();
            FormPanel.SuspendLayout();
            FormMenuPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            RightMenuPanel.SuspendLayout();
            LeftMenuPanel.SuspendLayout();
            ChoosePanel.SuspendLayout();
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
            FormMenuPanel.Controls.Add(lbl_rateshow, 1, 0);
            FormMenuPanel.Controls.Add(btn_maximize, 3, 0);
            FormMenuPanel.Controls.Add(btn_exit, 4, 0);
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
            btn_minimize.TabIndex = 101;
            btn_minimize.TabStop = false;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
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
            lbl_rateshow.TabIndex = 104;
            lbl_rateshow.Text = "Rate Show";
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
            btn_maximize.TabIndex = 105;
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
            btn_exit.TabIndex = 106;
            btn_exit.TabStop = false;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // MainPanel
            // 
            MainPanel.ColumnCount = 3;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 920F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainPanel.Controls.Add(ShowListPanel, 1, 0);
            MainPanel.Controls.Add(RightMenuPanel, 2, 0);
            MainPanel.Controls.Add(LeftMenuPanel, 0, 0);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 63);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 1;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainPanel.Size = new Size(1434, 744);
            MainPanel.TabIndex = 1;
            // 
            // ShowListPanel
            // 
            ShowListPanel.AutoScroll = true;
            ShowListPanel.Dock = DockStyle.Fill;
            ShowListPanel.Location = new Point(260, 3);
            ShowListPanel.Name = "ShowListPanel";
            ShowListPanel.Size = new Size(914, 738);
            ShowListPanel.TabIndex = 0;
            // 
            // RightMenuPanel
            // 
            RightMenuPanel.ColumnCount = 3;
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            RightMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 5F));
            RightMenuPanel.Controls.Add(tbox_genre, 1, 5);
            RightMenuPanel.Controls.Add(tbox_watcheddate, 1, 13);
            RightMenuPanel.Controls.Add(tbox_releasedate, 1, 11);
            RightMenuPanel.Controls.Add(tbox_topic, 1, 7);
            RightMenuPanel.Controls.Add(tbox_url, 1, 3);
            RightMenuPanel.Controls.Add(tbox_language, 1, 9);
            RightMenuPanel.Controls.Add(tbox_rate, 1, 15);
            RightMenuPanel.Controls.Add(tbox_showname, 1, 1);
            RightMenuPanel.Controls.Add(btn_operations, 1, 17);
            RightMenuPanel.Dock = DockStyle.Fill;
            RightMenuPanel.Location = new Point(1180, 3);
            RightMenuPanel.Name = "RightMenuPanel";
            RightMenuPanel.RowCount = 19;
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            RightMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            RightMenuPanel.Size = new Size(251, 738);
            RightMenuPanel.TabIndex = 1;
            // 
            // tbox_genre
            // 
            tbox_genre.BackColor = Color.White;
            tbox_genre.Dock = DockStyle.Fill;
            tbox_genre.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_genre.ForeColor = Color.Black;
            tbox_genre.Location = new Point(8, 212);
            tbox_genre.Name = "tbox_genre";
            tbox_genre.PlaceholderText = "Genre";
            tbox_genre.Size = new Size(235, 35);
            tbox_genre.TabIndex = 12;
            // 
            // tbox_watcheddate
            // 
            tbox_watcheddate.BackColor = Color.White;
            tbox_watcheddate.Dock = DockStyle.Fill;
            tbox_watcheddate.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_watcheddate.ForeColor = Color.Black;
            tbox_watcheddate.Location = new Point(8, 452);
            tbox_watcheddate.Name = "tbox_watcheddate";
            tbox_watcheddate.PlaceholderText = "Watched Date";
            tbox_watcheddate.Size = new Size(235, 35);
            tbox_watcheddate.TabIndex = 16;
            // 
            // tbox_releasedate
            // 
            tbox_releasedate.BackColor = Color.White;
            tbox_releasedate.Dock = DockStyle.Fill;
            tbox_releasedate.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_releasedate.ForeColor = Color.Black;
            tbox_releasedate.Location = new Point(8, 392);
            tbox_releasedate.Name = "tbox_releasedate";
            tbox_releasedate.PlaceholderText = "Release Date";
            tbox_releasedate.Size = new Size(235, 35);
            tbox_releasedate.TabIndex = 15;
            // 
            // tbox_topic
            // 
            tbox_topic.BackColor = Color.White;
            tbox_topic.Dock = DockStyle.Fill;
            tbox_topic.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_topic.ForeColor = Color.Black;
            tbox_topic.Location = new Point(8, 272);
            tbox_topic.Name = "tbox_topic";
            tbox_topic.PlaceholderText = "Topic";
            tbox_topic.Size = new Size(235, 35);
            tbox_topic.TabIndex = 13;
            // 
            // tbox_url
            // 
            tbox_url.BackColor = Color.White;
            tbox_url.Dock = DockStyle.Fill;
            tbox_url.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_url.ForeColor = Color.Black;
            tbox_url.Location = new Point(8, 152);
            tbox_url.Name = "tbox_url";
            tbox_url.PlaceholderText = "Image URL";
            tbox_url.Size = new Size(235, 35);
            tbox_url.TabIndex = 11;
            // 
            // tbox_language
            // 
            tbox_language.BackColor = Color.White;
            tbox_language.Dock = DockStyle.Fill;
            tbox_language.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_language.ForeColor = Color.Black;
            tbox_language.Location = new Point(8, 332);
            tbox_language.Name = "tbox_language";
            tbox_language.PlaceholderText = "Language";
            tbox_language.Size = new Size(235, 35);
            tbox_language.TabIndex = 14;
            // 
            // tbox_rate
            // 
            tbox_rate.BackColor = Color.White;
            tbox_rate.Dock = DockStyle.Fill;
            tbox_rate.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_rate.ForeColor = Color.Black;
            tbox_rate.Location = new Point(8, 512);
            tbox_rate.Name = "tbox_rate";
            tbox_rate.PlaceholderText = "Rate";
            tbox_rate.Size = new Size(235, 35);
            tbox_rate.TabIndex = 17;
            // 
            // tbox_showname
            // 
            tbox_showname.BackColor = Color.White;
            tbox_showname.Dock = DockStyle.Fill;
            tbox_showname.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_showname.ForeColor = Color.Black;
            tbox_showname.Location = new Point(8, 92);
            tbox_showname.Name = "tbox_showname";
            tbox_showname.PlaceholderText = "Show Name";
            tbox_showname.Size = new Size(235, 35);
            tbox_showname.TabIndex = 10;
            // 
            // btn_operations
            // 
            btn_operations.Dock = DockStyle.Fill;
            btn_operations.FlatAppearance.BorderSize = 0;
            btn_operations.FlatStyle = FlatStyle.Flat;
            btn_operations.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_operations.Location = new Point(8, 572);
            btn_operations.Name = "btn_operations";
            btn_operations.Size = new Size(235, 74);
            btn_operations.TabIndex = 18;
            btn_operations.Text = "Operation";
            btn_operations.UseVisualStyleBackColor = true;
            btn_operations.Click += btn_operations_Click;
            // 
            // LeftMenuPanel
            // 
            LeftMenuPanel.ColumnCount = 3;
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            LeftMenuPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            LeftMenuPanel.Controls.Add(btn_back, 1, 19);
            LeftMenuPanel.Controls.Add(btn_search, 1, 15);
            LeftMenuPanel.Controls.Add(btn_delete, 1, 3);
            LeftMenuPanel.Controls.Add(cbox_sort, 1, 13);
            LeftMenuPanel.Controls.Add(tbox_searchname, 1, 5);
            LeftMenuPanel.Controls.Add(btn_new, 1, 1);
            LeftMenuPanel.Controls.Add(tbox_searchlanguage, 1, 11);
            LeftMenuPanel.Controls.Add(tbox_searchtopic, 1, 9);
            LeftMenuPanel.Controls.Add(tbox_searchgenre, 1, 7);
            LeftMenuPanel.Controls.Add(ChoosePanel, 1, 17);
            LeftMenuPanel.Dock = DockStyle.Fill;
            LeftMenuPanel.Location = new Point(3, 3);
            LeftMenuPanel.Name = "LeftMenuPanel";
            LeftMenuPanel.RowCount = 21;
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            LeftMenuPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 5F));
            LeftMenuPanel.Size = new Size(251, 738);
            LeftMenuPanel.TabIndex = 2;
            // 
            // btn_back
            // 
            btn_back.Dock = DockStyle.Fill;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_back.Image = (Image)resources.GetObject("btn_back.Image");
            btn_back.ImageAlign = ContentAlignment.MiddleLeft;
            btn_back.Location = new Point(28, 656);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(194, 74);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btn_search
            // 
            btn_search.Dock = DockStyle.Fill;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.ImageAlign = ContentAlignment.MiddleLeft;
            btn_search.Location = new Point(28, 508);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(194, 74);
            btn_search.TabIndex = 8;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // btn_delete
            // 
            btn_delete.Dock = DockStyle.Fill;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.Image = (Image)resources.GetObject("btn_delete.Image");
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(28, 108);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(194, 74);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cbox_sort
            // 
            cbox_sort.BackColor = Color.White;
            cbox_sort.Dock = DockStyle.Fill;
            cbox_sort.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cbox_sort.ForeColor = Color.Black;
            cbox_sort.FormattingEnabled = true;
            cbox_sort.Items.AddRange(new object[] { "by Watched Date", "by Watched Date Reverse", "by Rate", "by Rate Reverse", "by Release Date", "by Release Date Reverse", "by Name", "by Name Reverse" });
            cbox_sort.Location = new Point(28, 448);
            cbox_sort.Name = "cbox_sort";
            cbox_sort.Size = new Size(194, 37);
            cbox_sort.TabIndex = 7;
            // 
            // tbox_searchname
            // 
            tbox_searchname.BackColor = Color.White;
            tbox_searchname.Dock = DockStyle.Fill;
            tbox_searchname.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_searchname.ForeColor = Color.Black;
            tbox_searchname.Location = new Point(28, 208);
            tbox_searchname.Name = "tbox_searchname";
            tbox_searchname.PlaceholderText = "search name";
            tbox_searchname.Size = new Size(194, 35);
            tbox_searchname.TabIndex = 3;
            // 
            // btn_new
            // 
            btn_new.Dock = DockStyle.Fill;
            btn_new.FlatAppearance.BorderSize = 0;
            btn_new.FlatStyle = FlatStyle.Flat;
            btn_new.Font = new Font("MV Boli", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_new.Image = (Image)resources.GetObject("btn_new.Image");
            btn_new.ImageAlign = ContentAlignment.MiddleLeft;
            btn_new.Location = new Point(28, 8);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(194, 74);
            btn_new.TabIndex = 0;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = true;
            btn_new.Click += btn_new_Click;
            // 
            // tbox_searchlanguage
            // 
            tbox_searchlanguage.BackColor = Color.White;
            tbox_searchlanguage.Dock = DockStyle.Fill;
            tbox_searchlanguage.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_searchlanguage.ForeColor = Color.Black;
            tbox_searchlanguage.Location = new Point(28, 388);
            tbox_searchlanguage.Name = "tbox_searchlanguage";
            tbox_searchlanguage.PlaceholderText = "search language";
            tbox_searchlanguage.Size = new Size(194, 35);
            tbox_searchlanguage.TabIndex = 6;
            // 
            // tbox_searchtopic
            // 
            tbox_searchtopic.BackColor = Color.White;
            tbox_searchtopic.Dock = DockStyle.Fill;
            tbox_searchtopic.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_searchtopic.ForeColor = Color.Black;
            tbox_searchtopic.Location = new Point(28, 328);
            tbox_searchtopic.Name = "tbox_searchtopic";
            tbox_searchtopic.PlaceholderText = "search topic";
            tbox_searchtopic.Size = new Size(194, 35);
            tbox_searchtopic.TabIndex = 5;
            // 
            // tbox_searchgenre
            // 
            tbox_searchgenre.BackColor = Color.White;
            tbox_searchgenre.Dock = DockStyle.Fill;
            tbox_searchgenre.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_searchgenre.ForeColor = Color.Black;
            tbox_searchgenre.Location = new Point(28, 268);
            tbox_searchgenre.Name = "tbox_searchgenre";
            tbox_searchgenre.PlaceholderText = "search genre";
            tbox_searchgenre.Size = new Size(194, 35);
            tbox_searchgenre.TabIndex = 4;
            // 
            // ChoosePanel
            // 
            ChoosePanel.ColumnCount = 2;
            ChoosePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ChoosePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            ChoosePanel.Controls.Add(btn_set, 1, 0);
            ChoosePanel.Controls.Add(tbox_choose, 0, 0);
            ChoosePanel.Dock = DockStyle.Fill;
            ChoosePanel.Location = new Point(28, 608);
            ChoosePanel.Name = "ChoosePanel";
            ChoosePanel.RowCount = 1;
            ChoosePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ChoosePanel.Size = new Size(194, 34);
            ChoosePanel.TabIndex = 10;
            // 
            // btn_set
            // 
            btn_set.Dock = DockStyle.Fill;
            btn_set.FlatAppearance.BorderSize = 0;
            btn_set.FlatStyle = FlatStyle.Flat;
            btn_set.Font = new Font("MV Boli", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_set.Location = new Point(100, 3);
            btn_set.Name = "btn_set";
            btn_set.Size = new Size(91, 28);
            btn_set.TabIndex = 0;
            btn_set.Text = "Set";
            btn_set.UseVisualStyleBackColor = true;
            btn_set.Click += btn_set_Click;
            // 
            // tbox_choose
            // 
            tbox_choose.BackColor = Color.White;
            tbox_choose.Dock = DockStyle.Fill;
            tbox_choose.Font = new Font("Georgia", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_choose.ForeColor = Color.Black;
            tbox_choose.Location = new Point(3, 3);
            tbox_choose.Name = "tbox_choose";
            tbox_choose.PlaceholderText = "0";
            tbox_choose.Size = new Size(91, 29);
            tbox_choose.TabIndex = 1;
            tbox_choose.TextAlign = HorizontalAlignment.Right;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1440, 810);
            Controls.Add(FormPanel);
            ForeColor = Color.FromArgb(252, 196, 25);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            FormPanel.ResumeLayout(false);
            FormMenuPanel.ResumeLayout(false);
            FormMenuPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            RightMenuPanel.ResumeLayout(false);
            RightMenuPanel.PerformLayout();
            LeftMenuPanel.ResumeLayout(false);
            LeftMenuPanel.PerformLayout();
            ChoosePanel.ResumeLayout(false);
            ChoosePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel FormPanel;
        private TableLayoutPanel FormMenuPanel;
        private Button btn_minimize;
        private Label lbl_rateshow;
        private Button btn_maximize;
        private Button btn_exit;
        private TableLayoutPanel MainPanel;
        private FlowLayoutPanel ShowListPanel;
        private TableLayoutPanel RightMenuPanel;
        private TextBox tbox_rate;
        private TextBox tbox_showname;
        private TextBox tbox_language;
        private TextBox tbox_url;
        private TextBox tbox_watcheddate;
        private TextBox tbox_releasedate;
        private TextBox tbox_topic;
        private TextBox tbox_genre;
        private Button btn_operations;
        private TableLayoutPanel LeftMenuPanel;
        private ComboBox cbox_sort;
        private ComboBox cbox_search;
        private TextBox tbox_searchname;
        private Button btn_set;
        private Button btn_new;
        private Button btn_back;
        private Button btn_search;
        private Button btn_delete;
        private TextBox tbox_searchlanguage;
        private TextBox tbox_searchtopic;
        private TextBox tbox_searchgenre;
        private TableLayoutPanel ChoosePanel;
        private TextBox tbox_choose;
    }
}