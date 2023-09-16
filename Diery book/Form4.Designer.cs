namespace Diery_book
{
    partial class Form4
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
            this.dropdownlist = new System.Windows.Forms.ComboBox();
            this.txtcolor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(350, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "پس زمینه";
            // 
            // dropdownlist
            // 
            this.dropdownlist.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.dropdownlist.DisplayMember = "color";
            this.dropdownlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownlist.FormattingEnabled = true;
            this.dropdownlist.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dropdownlist.Items.AddRange(new object[] {
            "Maroon",
            "LightSlateGray"});
            this.dropdownlist.Location = new System.Drawing.Point(223, 12);
            this.dropdownlist.Name = "dropdownlist";
            this.dropdownlist.Size = new System.Drawing.Size(121, 24);
            this.dropdownlist.TabIndex = 1;
            this.dropdownlist.SelectedIndexChanged += new System.EventHandler(this.dropdownlist_SelectedIndexChanged);
            // 
            // txtcolor
            // 
            this.txtcolor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtcolor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.txtcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtcolor.FormattingEnabled = true;
            this.txtcolor.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txtcolor.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Blue",
            "DarkRed",
            "Black",
            "White",
            "Skyblue",
            "Gray"});
            this.txtcolor.Location = new System.Drawing.Point(223, 59);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(121, 23);
            this.txtcolor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Morvarid", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(350, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "رنگ متن";
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(13, 312);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(107, 36);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "ذخیره";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(438, 360);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.txtcolor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dropdownlist);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dropdownlist;
        private System.Windows.Forms.ComboBox txtcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebtn;
    }
}