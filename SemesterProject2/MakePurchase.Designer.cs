namespace SemesterProject2
{
    partial class MakePurchase
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
            this.btn_go = new System.Windows.Forms.Button();
            this.comb_items = new System.Windows.Forms.ComboBox();
            this.lbl_items = new System.Windows.Forms.Label();
            this.lbl_quant = new System.Windows.Forms.Label();
            this.num_txt = new System.Windows.Forms.NumericUpDown();
            this.date_picker = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_cust = new System.Windows.Forms.Label();
            this.txt_cust = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_txt)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(568, 326);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(76, 47);
            this.btn_go.TabIndex = 0;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // comb_items
            // 
            this.comb_items.FormattingEnabled = true;
            this.comb_items.Items.AddRange(new object[] {
            "Chips",
            "Soda",
            "Sandwiches",
            "Snapple",
            "Tissues",
            "Grape Juice"});
            this.comb_items.Location = new System.Drawing.Point(261, 101);
            this.comb_items.Name = "comb_items";
            this.comb_items.Size = new System.Drawing.Size(121, 28);
            this.comb_items.TabIndex = 1;
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Location = new System.Drawing.Point(157, 109);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(49, 20);
            this.lbl_items.TabIndex = 2;
            this.lbl_items.Text = "Items";
            // 
            // lbl_quant
            // 
            this.lbl_quant.AutoSize = true;
            this.lbl_quant.Location = new System.Drawing.Point(148, 167);
            this.lbl_quant.Name = "lbl_quant";
            this.lbl_quant.Size = new System.Drawing.Size(68, 20);
            this.lbl_quant.TabIndex = 3;
            this.lbl_quant.Text = "Quantity";
            // 
            // num_txt
            // 
            this.num_txt.Location = new System.Drawing.Point(261, 160);
            this.num_txt.Name = "num_txt";
            this.num_txt.Size = new System.Drawing.Size(120, 26);
            this.num_txt.TabIndex = 4;
            // 
            // date_picker
            // 
            this.date_picker.Location = new System.Drawing.Point(261, 235);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(285, 26);
            this.date_picker.TabIndex = 5;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(152, 235);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 20);
            this.lbl_date.TabIndex = 6;
            this.lbl_date.Text = "Date";
            // 
            // lbl_cust
            // 
            this.lbl_cust.AutoSize = true;
            this.lbl_cust.Location = new System.Drawing.Point(152, 326);
            this.lbl_cust.Name = "lbl_cust";
            this.lbl_cust.Size = new System.Drawing.Size(99, 20);
            this.lbl_cust.TabIndex = 7;
            this.lbl_cust.Text = "Customer ID";
            // 
            // txt_cust
            // 
            this.txt_cust.Location = new System.Drawing.Point(296, 326);
            this.txt_cust.Name = "txt_cust";
            this.txt_cust.Size = new System.Drawing.Size(100, 26);
            this.txt_cust.TabIndex = 8;
            // 
            // MakePurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_cust);
            this.Controls.Add(this.lbl_cust);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.num_txt);
            this.Controls.Add(this.lbl_quant);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.comb_items);
            this.Controls.Add(this.btn_go);
            this.Name = "MakePurchase";
            this.Text = "Make Purchase";
            ((System.ComponentModel.ISupportInitialize)(this.num_txt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.ComboBox comb_items;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Label lbl_quant;
        private System.Windows.Forms.NumericUpDown num_txt;
        private System.Windows.Forms.DateTimePicker date_picker;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_cust;
        private System.Windows.Forms.TextBox txt_cust;
    }
}