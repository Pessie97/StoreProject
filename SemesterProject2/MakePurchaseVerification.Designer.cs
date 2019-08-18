namespace SemesterProject2
{
    partial class MakePurchaseVerification
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
            this.lbl_custid = new System.Windows.Forms.Label();
            this.txt_cust = new System.Windows.Forms.TextBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_custid
            // 
            this.lbl_custid.AutoSize = true;
            this.lbl_custid.Location = new System.Drawing.Point(124, 82);
            this.lbl_custid.Name = "lbl_custid";
            this.lbl_custid.Size = new System.Drawing.Size(99, 20);
            this.lbl_custid.TabIndex = 0;
            this.lbl_custid.Text = "Customer ID";
            // 
            // txt_cust
            // 
            this.txt_cust.Location = new System.Drawing.Point(302, 79);
            this.txt_cust.Name = "txt_cust";
            this.txt_cust.Size = new System.Drawing.Size(100, 26);
            this.txt_cust.TabIndex = 1;
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(237, 142);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(80, 36);
            this.btn_sub.TabIndex = 2;
            this.btn_sub.Text = "Go";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // MakePurchaseVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 217);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.txt_cust);
            this.Controls.Add(this.lbl_custid);
            this.Name = "MakePurchaseVerification";
            this.Text = "Make Purchase";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_custid;
        private System.Windows.Forms.TextBox txt_cust;
        private System.Windows.Forms.Button btn_sub;
    }
}