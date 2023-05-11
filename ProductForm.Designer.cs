namespace Dz
{
    partial class ProductForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.discountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.DiscountLB = new System.Windows.Forms.Label();
            this.QuantityLB = new System.Windows.Forms.Label();
            this.CountryLB = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(65)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(0, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "----------------------------------------------------------------";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.NameLB.Location = new System.Drawing.Point(12, 110);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(78, 27);
            this.NameLB.TabIndex = 3;
            this.NameLB.Text = "Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.OKBtn);
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.countryComboBox);
            this.panel1.Controls.Add(this.discountNumericUpDown);
            this.panel1.Controls.Add(this.quantityNumericUpDown);
            this.panel1.Controls.Add(this.priceNumericUpDown);
            this.panel1.Controls.Add(this.nameTB);
            this.panel1.Controls.Add(this.DiscountLB);
            this.panel1.Controls.Add(this.QuantityLB);
            this.panel1.Controls.Add(this.CountryLB);
            this.panel1.Controls.Add(this.PriceLB);
            this.panel1.Controls.Add(this.NameLB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 560);
            this.panel1.TabIndex = 0;
            // 
            // OKBtn
            // 
            this.OKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.OKBtn.FlatAppearance.BorderSize = 0;
            this.OKBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKBtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OKBtn.Location = new System.Drawing.Point(204, 472);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(123, 76);
            this.OKBtn.TabIndex = 14;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = false;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelBtn.Location = new System.Drawing.Point(12, 472);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(123, 76);
            this.CancelBtn.TabIndex = 13;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "Ukraine",
            "USA",
            "Great Britain",
            "Poland",
            "Austria",
            "Finland"});
            this.countryComboBox.Location = new System.Drawing.Point(152, 316);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(175, 28);
            this.countryComboBox.TabIndex = 12;
            // 
            // discountNumericUpDown
            // 
            this.discountNumericUpDown.Location = new System.Drawing.Point(152, 398);
            this.discountNumericUpDown.Name = "discountNumericUpDown";
            this.discountNumericUpDown.Size = new System.Drawing.Size(175, 27);
            this.discountNumericUpDown.TabIndex = 11;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(152, 243);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(175, 27);
            this.quantityNumericUpDown.TabIndex = 10;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.Location = new System.Drawing.Point(152, 178);
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(175, 27);
            this.priceNumericUpDown.TabIndex = 9;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(152, 110);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(175, 27);
            this.nameTB.TabIndex = 8;
            // 
            // DiscountLB
            // 
            this.DiscountLB.AutoSize = true;
            this.DiscountLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DiscountLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.DiscountLB.Location = new System.Drawing.Point(12, 398);
            this.DiscountLB.Name = "DiscountLB";
            this.DiscountLB.Size = new System.Drawing.Size(106, 27);
            this.DiscountLB.TabIndex = 7;
            this.DiscountLB.Text = "Discount";
            // 
            // QuantityLB
            // 
            this.QuantityLB.AutoSize = true;
            this.QuantityLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuantityLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.QuantityLB.Location = new System.Drawing.Point(12, 243);
            this.QuantityLB.Name = "QuantityLB";
            this.QuantityLB.Size = new System.Drawing.Size(103, 27);
            this.QuantityLB.TabIndex = 6;
            this.QuantityLB.Text = "Quantity";
            // 
            // CountryLB
            // 
            this.CountryLB.AutoSize = true;
            this.CountryLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountryLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.CountryLB.Location = new System.Drawing.Point(12, 317);
            this.CountryLB.Name = "CountryLB";
            this.CountryLB.Size = new System.Drawing.Size(96, 27);
            this.CountryLB.TabIndex = 5;
            this.CountryLB.Text = "Country";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriceLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.PriceLB.Location = new System.Drawing.Point(12, 178);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(69, 27);
            this.PriceLB.TabIndex = 4;
            this.PriceLB.Text = "Price:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dz.Properties.Resources.info;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 51);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 560);
            this.Controls.Add(this.panel1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.discountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DiscountLB;
        private System.Windows.Forms.Label QuantityLB;
        private System.Windows.Forms.Label CountryLB;
        private System.Windows.Forms.Label PriceLB;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.NumericUpDown discountNumericUpDown;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}