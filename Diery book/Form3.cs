using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diery_book
{
    public partial class Form3 : Form
    {
        IDierybook repository;
        public Form3()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            repository = new DieryRepository();
        }
      public  int bookID = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
        
            DataTable dt =repository.SelectRow(bookID);
            titlebx.Text =dt.Rows[0][1].ToString();
            datebx.Text = dt.Rows[0][2].ToString();
            if (dt.Rows[0][3] != null)
            {
                pbimg.Image = repository.ConvertByteArrayToImage((byte[])dt.Rows[0][3]);
            }
            else
            {

            }
            descriptionbx.Text = dt.Rows[0][4].ToString();
        }
    }
}
