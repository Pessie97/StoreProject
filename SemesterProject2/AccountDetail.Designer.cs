namespace SemesterProject2
{
    partial class AccountDetail
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
            this.lbl_custID = new System.Windows.Forms.Label();
            this.txt_custID = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_custID
            // 
            this.lbl_custID.AutoSize = true;
            this.lbl_custID.Location = new System.Drawing.Point(262, 99);
            this.lbl_custID.Name = "lbl_custID";
            this.lbl_custID.Size = new System.Drawing.Size(91, 20);
            this.lbl_custID.TabIndex = 0;
            this.lbl_custID.Text = "Cutomer ID";
            // 
            // txt_custID
            // 
            this.txt_custID.Location = new System.Drawing.Point(438, 96);
            this.txt_custID.Name = "txt_custID";
            this.txt_custID.Size = new System.Drawing.Size(124, 26);
            this.txt_custID.TabIndex = 1;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(296, 165);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(67, 42);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "Go";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(262, 307);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(438, 165);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(74, 42);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_pay
            // 
            this.btn_pay.Location = new System.Drawing.Point(79, 165);
            this.btn_pay.Name = "btn_pay";
            this.btn_pay.Size = new System.Drawing.Size(162, 41);
            this.btn_pay.TabIndex = 5;
            this.btn_pay.Text = "Make Payment";
            this.btn_pay.UseVisualStyleBackColor = true;
            this.btn_pay.Click += new System.EventHandler(this.btn_pay_Click);
            // 
            // AccountDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.btn_pay);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_custID);
            this.Controls.Add(this.lbl_custID);
            this.Name = "AccountDetail";
            this.Text = "AccountDetail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_custID;
        private System.Windows.Forms.TextBox txt_custID;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_pay;
    }
}