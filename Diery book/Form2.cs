using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diery_book
{
    public partial class Form2 : Form
    {
        IDierybook repository;
        public int BOOKId = 0;
        public Form2()
        {
            
            InitializeComponent();
            repository = new DieryRepository();
        }
       bool validationinputs()
        {
            bool isvalid = true;
            if (txtTitle.Text == "")
            {
                MessageBox.Show("لطفا عنوان خاطره را وارد کنید", "خطا", MessageBoxButtons.OK);
                isvalid = false;
            }
            if (txtDate.Text == "")
            {
                MessageBox.Show("لطفا تاریخ خاطره را وارد کنید", "خطا", MessageBoxButtons.OK);
                isvalid = false;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("لطفا  خاطره خود را وارد کنید", "خطا", MessageBoxButtons.OK);
                isvalid = false;
            }
            return isvalid;
        }
        

        private void submitbtn_Click(object sender, EventArgs e)
        {
            if (validationinputs() && submitbtn.Text=="ثبت")
            {
                bool isSucces = repository.Insert(txtTitle.Text, txtDate.Text,repository.ConvertImgToBytes(img.Image), txtDescription.Text);
                if (isSucces == true)
                {
                    MessageBox.Show("عملیات با موفقیت انجام شد","اطلاع");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("عملیات شکست خورد", "هشدار");
                }
            }
            if(validationinputs() && submitbtn.Text == "ویرایش")
            {
                bool isSuccess = repository.Edit(BOOKId, txtTitle.Text, txtDate.Text, repository.ConvertImgToBytes(img.Image), txtDescription.Text);
                if(isSuccess == true)
                {
                    MessageBox.Show("ویرایش با موفقیت انجام شد", "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("ویرایش با انجام نشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void uploadbtn_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg)|*.jpg;*.jpeg", Multiselect = false })
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string FileName = ofd.FileName;
                    txtimage.Text = FileName;
                  img.Image = new Bitmap(ofd.FileName);
                  
                }
                
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (BOOKId == 0)
            {
                var dateAndTime = DateTime.Now;
                DateTime pcdate = new DateTime(dateAndTime.Year, dateAndTime.Month, dateAndTime.Day);
                var Calendar = new PersianCalendar();
                var persianDate = new DateTime(Calendar.GetYear(pcdate), Calendar.GetMonth(pcdate), Calendar.GetDayOfMonth(pcdate));
                var result = persianDate.ToString("yyyy MMM ddd");
                txtDate.Text =result;
                this.Text = "ثبت";
            }
            else
            {
                this.Text = "ویرایش خاطره";
                DataTable dt = repository.SelectRow(BOOKId);
                txtTitle.Text = dt.Rows[0][1].ToString();
                txtDate.Text = dt.Rows[0][2].ToString();            
                    img.Image = repository.ConvertByteArrayToImage((byte[])dt.Rows[0][3]);
                    txtDescription.Text = dt.Rows[0][4].ToString();
                submitbtn.Text = "ویرایش";
            }
        }
    }
}
