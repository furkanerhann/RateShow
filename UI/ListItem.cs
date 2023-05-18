using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        #region properties
        private string _header;
        private string _info;
        private string _watched;
        private string _rate;
        private Image _banner;
        [Category("Custom Props")]
        public string Header
        {
            get { return _header; }
            set { _header = value; lbl_header.Text = value; }
        }
        [Category("Custom Props")]
        public string Info
        {
            get { return _info; }
            set { _info = value; lbl_info.Text = value; }
        }
        [Category("Custom Props")]
        public string Watched
        {
            get { return _watched; }
            set { _watched = value; lbl_watched.Text = value; }
        }
        [Category("Custom Props")]
        public string Rate
        {
            get { return _rate; }
            set { _rate = value; lbl_rate.Text = value; }
        }
        [Category("Custom Props")]
        public Image Banner
        {
            get { return _banner; }
            set { _banner = value; ItemImage.Image = value; }
        }

        #endregion
    }
}
