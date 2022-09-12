namespace WindowsFormsApplication4
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pinb1 = new System.Windows.Forms.Button();
            this.pint1 = new System.Windows.Forms.TextBox();
            this.pint2 = new System.Windows.Forms.TextBox();
            this.pint3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pinl1 = new System.Windows.Forms.Label();
            this.pinl2 = new System.Windows.Forms.Label();
            this.pinl3 = new System.Windows.Forms.Label();
            this.pinl4 = new System.Windows.Forms.Label();
            this.pinb2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pinb1
            // 
            this.pinb1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinb1.Location = new System.Drawing.Point(251, 387);
            this.pinb1.Margin = new System.Windows.Forms.Padding(4);
            this.pinb1.Name = "pinb1";
            this.pinb1.Size = new System.Drawing.Size(180, 49);
            this.pinb1.TabIndex = 0;
            this.pinb1.Text = "OK";
            this.pinb1.UseVisualStyleBackColor = true;
            this.pinb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pint1
            // 
            this.pint1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pint1.Location = new System.Drawing.Point(600, 105);
            this.pint1.Margin = new System.Windows.Forms.Padding(4);
            this.pint1.Name = "pint1";
            this.pint1.Size = new System.Drawing.Size(180, 23);
            this.pint1.TabIndex = 1;
            this.pint1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pint2
            // 
            this.pint2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pint2.Location = new System.Drawing.Point(600, 212);
            this.pint2.Margin = new System.Windows.Forms.Padding(4);
            this.pint2.Name = "pint2";
            this.pint2.Size = new System.Drawing.Size(180, 23);
            this.pint2.TabIndex = 2;
            this.pint2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pint3
            // 
            this.pint3.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pint3.Location = new System.Drawing.Point(600, 319);
            this.pint3.Margin = new System.Windows.Forms.Padding(4);
            this.pint3.Name = "pint3";
            this.pint3.Size = new System.Drawing.Size(180, 23);
            this.pint3.TabIndex = 3;
            this.pint3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // pinl1
            // 
            this.pinl1.AutoSize = true;
            this.pinl1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinl1.Location = new System.Drawing.Point(13, 11);
            this.pinl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinl1.Name = "pinl1";
            this.pinl1.Size = new System.Drawing.Size(45, 13);
            this.pinl1.TabIndex = 5;
            this.pinl1.Text = "label2";
            this.pinl1.Visible = false;
            this.pinl1.Click += new System.EventHandler(this.pinl1_Click);
            // 
            // pinl2
            // 
            this.pinl2.AutoSize = true;
            this.pinl2.BackColor = System.Drawing.Color.Transparent;
            this.pinl2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinl2.Location = new System.Drawing.Point(226, 105);
            this.pinl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinl2.Name = "pinl2";
            this.pinl2.Size = new System.Drawing.Size(205, 27);
            this.pinl2.TabIndex = 6;
            this.pinl2.Text = "ENTER PASSWORD";
            // 
            // pinl3
            // 
            this.pinl3.AutoSize = true;
            this.pinl3.BackColor = System.Drawing.Color.Transparent;
            this.pinl3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinl3.Location = new System.Drawing.Point(226, 208);
            this.pinl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinl3.Name = "pinl3";
            this.pinl3.Size = new System.Drawing.Size(258, 27);
            this.pinl3.TabIndex = 7;
            this.pinl3.Text = "ENTER NEW PASSWORD";
            this.pinl3.Click += new System.EventHandler(this.label4_Click);
            // 
            // pinl4
            // 
            this.pinl4.AutoSize = true;
            this.pinl4.BackColor = System.Drawing.Color.Transparent;
            this.pinl4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinl4.Location = new System.Drawing.Point(226, 312);
            this.pinl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pinl4.Name = "pinl4";
            this.pinl4.Size = new System.Drawing.Size(298, 27);
            this.pinl4.TabIndex = 8;
            this.pinl4.Text = "ENTER RENAME PASSWORD";
            // 
            // pinb2
            // 
            this.pinb2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinb2.Location = new System.Drawing.Point(577, 387);
            this.pinb2.Margin = new System.Windows.Forms.Padding(4);
            this.pinb2.Name = "pinb2";
            this.pinb2.Size = new System.Drawing.Size(180, 49);
            this.pinb2.TabIndex = 9;
            this.pinb2.Text = "CANCEL";
            this.pinb2.UseVisualStyleBackColor = true;
            this.pinb2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(410, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pinb2);
            this.Controls.Add(this.pinl4);
            this.Controls.Add(this.pinl3);
            this.Controls.Add(this.pinl2);
            this.Controls.Add(this.pinl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pint3);
            this.Controls.Add(this.pint2);
            this.Controls.Add(this.pint1);
            this.Controls.Add(this.pinb1);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "  bhb hhhnj f";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pinb1;
        private System.Windows.Forms.TextBox pint1;
        private System.Windows.Forms.TextBox pint2;
        private System.Windows.Forms.TextBox pint3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pinl1;
        private System.Windows.Forms.Label pinl2;
        private System.Windows.Forms.Label pinl3;
        private System.Windows.Forms.Label pinl4;
        private System.Windows.Forms.Button pinb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}