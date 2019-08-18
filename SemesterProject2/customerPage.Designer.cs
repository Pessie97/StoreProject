namespace SemesterProject2
{
    partial class customerPage
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
            this.options = new System.Windows.Forms.ComboBox();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.FormattingEnabled = true;
            this.options.Items.AddRange(new object[] {
            "Make Purchase",
            "View Store Items",
            "View Account Detail",
            "View Past Purchases"});
            this.options.Location = new System.Drawing.Point(226, 133);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(359, 28);
            this.options.TabIndex = 0;
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(382, 205);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 41);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "Go...";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(670, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 43);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // customerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.options);
            this.Name = "customerPage";
            this.Text = "customerPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox options;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.Button btn_exit;
    }
}