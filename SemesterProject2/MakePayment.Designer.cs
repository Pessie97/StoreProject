namespace SemesterProject2
{
    partial class MakePayment
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.chk_total = new System.Windows.Forms.CheckBox();
            this.chk_custom = new System.Windows.Forms.CheckBox();
            this.txt_custom = new System.Windows.Forms.TextBox();
            this.lbl_nt = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(67, 52);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(42, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "label";
            // 
            // chk_total
            // 
            this.chk_total.AutoSize = true;
            this.chk_total.Location = new System.Drawing.Point(172, 132);
            this.chk_total.Name = "chk_total";
            this.chk_total.Size = new System.Drawing.Size(132, 24);
            this.chk_total.TabIndex = 1;
            this.chk_total.Text = "Total Balance";
            this.chk_total.UseVisualStyleBackColor = true;
            // 
            // chk_custom
            // 
            this.chk_custom.AutoSize = true;
            this.chk_custom.Location = new System.Drawing.Point(539, 132);
            this.chk_custom.Name = "chk_custom";
            this.chk_custom.Size = new System.Drawing.Size(90, 24);
            this.chk_custom.TabIndex = 2;
            this.chk_custom.Text = "Custom";
            this.chk_custom.UseVisualStyleBackColor = true;
            // 
            // txt_custom
            // 
            this.txt_custom.Location = new System.Drawing.Point(334, 199);
            this.txt_custom.Name = "txt_custom";
            this.txt_custom.Size = new System.Drawing.Size(160, 26);
            this.txt_custom.TabIndex = 3;
            // 
            // lbl_nt
            // 
            this.lbl_nt.AutoSize = true;
            this.lbl_nt.Location = new System.Drawing.Point(310, 202);
            this.lbl_nt.Name = "lbl_nt";
            this.lbl_nt.Size = new System.Drawing.Size(18, 20);
            this.lbl_nt.TabIndex = 4;
            this.lbl_nt.Text = "$";
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(314, 293);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(104, 52);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(640, 352);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 52);
            this.btn_back.TabIndex = 6;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_nt);
            this.Controls.Add(this.txt_custom);
            this.Controls.Add(this.chk_custom);
            this.Controls.Add(this.chk_total);
            this.Controls.Add(this.lbl_name);
            this.Name = "MakePayment";
            this.Text = "MakePayment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.CheckBox chk_total;
        private System.Windows.Forms.CheckBox chk_custom;
        private System.Windows.Forms.TextBox txt_custom;
        private System.Windows.Forms.Label lbl_nt;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_back;
    }
}