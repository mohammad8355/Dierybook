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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
          
        }
        
        private void dropdownlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form3 frmadd = new Form3();
            string colorname = dropdownlist.SelectedText;
            Color color = Color.FromName(colorname);
            frmadd.BackColor = color;
           
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Form3 frmadd = new Form3();
         
            
        }
    }
}
