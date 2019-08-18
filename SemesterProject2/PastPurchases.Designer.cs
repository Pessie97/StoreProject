namespace SemesterProject2
{
    partial class PastPurchases
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
            this.btn_submit = new System.Windows.Forms.Button();
            this.lbl_custId = new System.Windows.Forms.Label();
            this.txt_custId = new System.Windows.Forms.TextBox();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(327, 196);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(76, 43);
            this.btn_submit.TabIndex = 0;
            this.btn_submit.Text = "Go";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // lbl_custId
            // 
            this.lbl_custId.AutoSize = true;
            this.lbl_custId.Location = new System.Drawing.Point(213, 105);
            this.lbl_custId.Name = "lbl_custId";
            this.lbl_custId.Size = new System.Drawing.Size(99, 20);
            this.lbl_custId.TabIndex = 1;
            this.lbl_custId.Text = "Customer ID";
            // 
            // txt_custId
            // 
            this.txt_custId.Location = new System.Drawing.Point(416, 99);
            this.txt_custId.Name = "txt_custId";
            this.txt_custId.Size = new System.Drawing.Size(100, 26);
            this.txt_custId.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(217, 278);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 20);
            this.lbl_result.TabIndex = 3;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(483, 196);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(76, 43);
            this.btn_back.TabIndex = 4;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // PastPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.txt_custId);
            this.Controls.Add(this.lbl_custId);
            this.Controls.Add(this.btn_submit);
            this.Name = "PastPurchases";
            this.Text = "Past Purchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Label lbl_custId;
        private System.Windows.Forms.TextBox txt_custId;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_back;
    }
}