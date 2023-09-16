namespace Diery_book
{
    partial class Form3
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
            this.titlebx = new System.Windows.Forms.TextBox();
            this.datebx = new System.Windows.Forms.TextBox();
            this.descriptionbx = new System.Windows.Forms.TextBox();
            this.pbimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).BeginInit();
            this.SuspendLayout();
            // 
            // titlebx
            // 
            this.titlebx.BackColor = System.Drawing.Color.Brown;
            this.titlebx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titlebx.ForeColor = System.Drawing.Color.White;
            this.titlebx.Location = new System.Drawing.Point(74, 12);
            this.titlebx.Name = "titlebx";
            this.titlebx.ReadOnly = true;
            this.titlebx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.titlebx.Size = new System.Drawing.Size(344, 29);
            this.titlebx.TabIndex = 0;
            this.titlebx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // datebx
            // 
            this.datebx.BackColor = System.Drawing.Color.Brown;
            this.datebx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datebx.ForeColor = System.Drawing.Color.White;
            this.datebx.Location = new System.Drawing.Point(12, 412);
            this.datebx.Name = "datebx";
            this.datebx.ReadOnly = true;
            this.datebx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.datebx.Size = new System.Drawing.Size(103, 29);
            this.datebx.TabIndex = 1;
            this.datebx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descriptionbx
            // 
            this.descriptionbx.BackColor = System.Drawing.Color.Brown;
            this.descriptionbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionbx.ForeColor = System.Drawing.Color.White;
            this.descriptionbx.Location = new System.Drawing.Point(74, 233);
            this.descriptionbx.Multiline = true;
            this.descriptionbx.Name = "descriptionbx";
            this.descriptionbx.ReadOnly = true;
            this.descriptionbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionbx.Size = new System.Drawing.Size(344, 173);
            this.descriptionbx.TabIndex = 2;
            this.descriptionbx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pbimg
            // 
            this.pbimg.Location = new System.Drawing.Point(74, 48);
            this.pbimg.Name = "pbimg";
            this.pbimg.Size = new System.Drawing.Size(344, 179);
            this.pbimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbimg.TabIndex = 3;
            this.pbimg.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.pbimg);
            this.Controls.Add(this.descriptionbx);
            this.Controls.Add(this.datebx);
            this.Controls.Add(this.titlebx);
            this.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titlebx;
        private System.Windows.Forms.TextBox datebx;
        private System.Windows.Forms.TextBox descriptionbx;
        private System.Windows.Forms.PictureBox pbimg;
    }
}