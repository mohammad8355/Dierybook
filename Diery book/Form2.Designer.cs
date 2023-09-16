namespace Diery_book
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.img = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.uploadbtn = new System.Windows.Forms.Button();
            this.txtimage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.img)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(715, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "عنوان";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(506, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(203, 29);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDate.Location = new System.Drawing.Point(242, 20);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(203, 27);
            this.txtDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(451, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "تاریخ";
            // 
            // img
            // 
            this.img.Location = new System.Drawing.Point(12, 20);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(224, 152);
            this.img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img.TabIndex = 4;
            this.img.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(242, 55);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(514, 116);
            this.txtDescription.TabIndex = 5;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.submitbtn.Location = new System.Drawing.Point(607, 186);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(149, 40);
            this.submitbtn.TabIndex = 6;
            this.submitbtn.Text = "ثبت";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // uploadbtn
            // 
            this.uploadbtn.Location = new System.Drawing.Point(12, 179);
            this.uploadbtn.Name = "uploadbtn";
            this.uploadbtn.Size = new System.Drawing.Size(111, 34);
            this.uploadbtn.TabIndex = 7;
            this.uploadbtn.Text = "بارگذاری";
            this.uploadbtn.UseVisualStyleBackColor = true;
            this.uploadbtn.Click += new System.EventHandler(this.uploadbtn_Click);
            // 
            // txtimage
            // 
            this.txtimage.Location = new System.Drawing.Point(129, 178);
            this.txtimage.Name = "txtimage";
            this.txtimage.Size = new System.Drawing.Size(203, 29);
            this.txtimage.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 238);
            this.Controls.Add(this.txtimage);
            this.Controls.Add(this.uploadbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.img);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Morvarid", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox img;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button uploadbtn;
        private System.Windows.Forms.TextBox txtimage;
    }
}