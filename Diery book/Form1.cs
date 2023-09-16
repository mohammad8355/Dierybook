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
    public partial class Form1 : Form
    {
        IDierybook repository;
        public Form1()
        {
            InitializeComponent();
            repository = new DieryRepository();
        }
        private void BindGrid()
        {
            dgdiery.AutoGenerateColumns = false;
            dgdiery.DataSource = repository.SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            if (form.DialogResult== DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void showbtn_Click(object sender, EventArgs e)
        {
            if (dgdiery.CurrentRow != null)
            {
                int bookId = int.Parse(dgdiery.CurrentRow.Cells[0].Value.ToString());
                Form3 frmshow = new Form3();
                frmshow.bookID = bookId;
                if(frmshow.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void editbtn_Click(object sender, EventArgs e)
        {
            int bookId = int.Parse(dgdiery.CurrentRow.Cells[0].Value.ToString());
            Form2 frmedit = new Form2();
            frmedit.BOOKId = bookId;
            if(frmedit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            DialogResult dgr = MessageBox.Show("آیا از حذف این خاطره اطمینان دارید", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dgr == DialogResult.Yes)
            {
                int bookId = int.Parse(dgdiery.CurrentRow.Cells[0].Value.ToString());
                if (dgdiery.CurrentRow != null)
                {
                    repository.Delete(bookId);
                    BindGrid();
                }
                else
                {
                    MessageBox.Show("لطفا یک مورد را انتخاب کنید");
                }
            }
        }

        private void settingbtn_Click(object sender, EventArgs e)
        {
            Form4 frmsetting = new Form4();
            frmsetting.ShowDialog();
        }
    }
}
