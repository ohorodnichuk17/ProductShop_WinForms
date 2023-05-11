namespace Dz
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MinusBtn);
            this.panel1.Controls.Add(this.PlusBtn);
            this.panel1.Controls.Add(this.InfoBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 525);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dz.Properties.Resources.shop;
            this.pictureBox1.Location = new System.Drawing.Point(437, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 54);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MinusBtn
            // 
            this.MinusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.MinusBtn.FlatAppearance.BorderSize = 0;
            this.MinusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinusBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinusBtn.Location = new System.Drawing.Point(321, 441);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(123, 75);
            this.MinusBtn.TabIndex = 6;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = false;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.PlusBtn.FlatAppearance.BorderSize = 0;
            this.PlusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusBtn.Font = new System.Drawing.Font("Montserrat", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlusBtn.Location = new System.Drawing.Point(474, 441);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(123, 75);
            this.PlusBtn.TabIndex = 5;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = false;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.InfoBtn.FlatAppearance.BorderSize = 0;
            this.InfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoBtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InfoBtn.Location = new System.Drawing.Point(175, 441);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(123, 75);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Info";
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(247)))), ((int)(((byte)(195)))));
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditBtn.Location = new System.Drawing.Point(12, 442);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(123, 74);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(0, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(639, 340);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(65)))), ((int)(((byte)(250)))));
            this.label2.Location = new System.Drawing.Point(0, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(639, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(72)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Shop";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 525);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
