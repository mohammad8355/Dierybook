namespace Diery_book
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgdiery = new System.Windows.Forms.DataGridView();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addbtn = new System.Windows.Forms.ToolStripButton();
            this.editbtn = new System.Windows.Forms.ToolStripButton();
            this.deletebtn = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.showbtn = new System.Windows.Forms.ToolStripButton();
            this.settingbtn = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgdiery)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgdiery
            // 
            this.dgdiery.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgdiery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgdiery.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgdiery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdiery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookId,
            this.title,
            this.date,
            this.image,
            this.description});
            this.dgdiery.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdiery.Location = new System.Drawing.Point(12, 30);
            this.dgdiery.Name = "dgdiery";
            this.dgdiery.ReadOnly = true;
            this.dgdiery.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgdiery.RowTemplate.Height = 24;
            this.dgdiery.Size = new System.Drawing.Size(776, 444);
            this.dgdiery.TabIndex = 1;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "BookId";
            this.bookId.HeaderText = "id";
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Visible = false;
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.FillWeight = 54.42176F;
            this.title.HeaderText = "عنوان";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date";
            this.date.FillWeight = 87.72523F;
            this.date.HeaderText = "تاریخ";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 161;
            // 
            // image
            // 
            this.image.DataPropertyName = "Img";
            this.image.FillWeight = 116.4976F;
            this.image.HeaderText = "عکس";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 214;
            // 
            // description
            // 
            this.description.DataPropertyName = "Description";
            this.description.FillWeight = 141.3554F;
            this.description.HeaderText = "متن";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 260;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Addbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Addbtn.Image = ((System.Drawing.Image)(resources.GetObject("Addbtn.Image")));
            this.Addbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Addbtn.Margin = new System.Windows.Forms.Padding(2, 1, 3, 2);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(99, 24);
            this.Addbtn.Text = "افزودن خاطره";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.White;
            this.editbtn.Image = ((System.Drawing.Image)(resources.GetObject("editbtn.Image")));
            this.editbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editbtn.Margin = new System.Windows.Forms.Padding(2, 1, 3, 2);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(59, 24);
            this.editbtn.Text = "ویرایش";
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Red;
            this.deletebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebtn.Image = ((System.Drawing.Image)(resources.GetObject("deletebtn.Image")));
            this.deletebtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletebtn.Margin = new System.Windows.Forms.Padding(2, 1, 3, 2);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(45, 24);
            this.deletebtn.Text = "حذف";
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Addbtn,
            this.editbtn,
            this.deletebtn,
            this.showbtn,
            this.settingbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // showbtn
            // 
            this.showbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.showbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showbtn.Image = ((System.Drawing.Image)(resources.GetObject("showbtn.Image")));
            this.showbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.showbtn.Margin = new System.Windows.Forms.Padding(2, 1, 3, 2);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(54, 24);
            this.showbtn.Text = "نمایش";
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // settingbtn
            // 
            this.settingbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingbtn.Image = ((System.Drawing.Image)(resources.GetObject("settingbtn.Image")));
            this.settingbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingbtn.Name = "settingbtn";
            this.settingbtn.Size = new System.Drawing.Size(68, 24);
            this.settingbtn.Text = "تنظیمات";
            this.settingbtn.Click += new System.EventHandler(this.settingbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.dgdiery);
            this.Controls.Add(this.toolStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("B Morvarid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "دفترچه خاطرات";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdiery)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgdiery;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn image;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.ToolStripButton Addbtn;
        private System.Windows.Forms.ToolStripButton editbtn;
        private System.Windows.Forms.ToolStripButton deletebtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton showbtn;
        private System.Windows.Forms.ToolStripButton settingbtn;
    }
}

