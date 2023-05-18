namespace UI
{
    partial class ListItem
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            ItemPanel = new TableLayoutPanel();
            ItemImage = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_watched = new Label();
            lbl_header = new Label();
            lbl_info = new Label();
            lbl_rate = new Label();
            ItemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemImage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ItemPanel
            // 
            ItemPanel.ColumnCount = 5;
            ItemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ItemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            ItemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ItemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ItemPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            ItemPanel.Controls.Add(ItemImage, 1, 1);
            ItemPanel.Controls.Add(tableLayoutPanel1, 3, 1);
            ItemPanel.Dock = DockStyle.Fill;
            ItemPanel.Location = new Point(0, 0);
            ItemPanel.Name = "ItemPanel";
            ItemPanel.RowCount = 3;
            ItemPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            ItemPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            ItemPanel.Size = new Size(900, 180);
            ItemPanel.TabIndex = 0;
            // 
            // ItemImage
            // 
            ItemImage.Dock = DockStyle.Fill;
            ItemImage.Location = new Point(23, 13);
            ItemImage.Name = "ItemImage";
            ItemImage.Size = new Size(114, 154);
            ItemImage.SizeMode = PictureBoxSizeMode.Zoom;
            ItemImage.TabIndex = 0;
            ItemImage.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lbl_watched, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_header, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_info, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_rate, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(163, 13);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(714, 154);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_watched
            // 
            lbl_watched.Anchor = AnchorStyles.Left;
            lbl_watched.AutoSize = true;
            lbl_watched.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_watched.Location = new Point(3, 60);
            lbl_watched.Name = "lbl_watched";
            lbl_watched.Size = new Size(111, 19);
            lbl_watched.TabIndex = 2;
            lbl_watched.Text = "Watched 2020.01.01";
            // 
            // lbl_header
            // 
            lbl_header.Anchor = AnchorStyles.Left;
            lbl_header.AutoSize = true;
            lbl_header.Font = new Font("Haettenschweiler", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_header.Location = new Point(3, 3);
            lbl_header.Name = "lbl_header";
            lbl_header.Size = new Size(325, 34);
            lbl_header.TabIndex = 0;
            lbl_header.Text = "Sample Text Sample Text (2020)";
            // 
            // lbl_info
            // 
            lbl_info.Anchor = AnchorStyles.Left;
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_info.Location = new Point(3, 40);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(134, 19);
            lbl_info.TabIndex = 1;
            lbl_info.Text = "Sample, Text ● Sample";
            // 
            // lbl_rate
            // 
            lbl_rate.Anchor = AnchorStyles.Right;
            lbl_rate.AutoSize = true;
            lbl_rate.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_rate.Location = new Point(660, 124);
            lbl_rate.Name = "lbl_rate";
            lbl_rate.Size = new Size(51, 29);
            lbl_rate.TabIndex = 3;
            lbl_rate.Text = "10.00";
            // 
            // ListItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(ItemPanel);
            ForeColor = Color.Black;
            Name = "ListItem";
            Size = new Size(900, 180);
            ItemPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ItemImage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ItemPanel;
        private PictureBox ItemImage;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_watched;
        private Label lbl_header;
        private Label lbl_info;
        private Label lbl_rate;
    }
}
