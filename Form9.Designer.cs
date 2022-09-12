namespace WindowsFormsApplication4
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.finpb1 = new System.Windows.Forms.PictureBox();
            this.finl1 = new System.Windows.Forms.Label();
            this.finb1 = new System.Windows.Forms.Button();
            this.finb2 = new System.Windows.Forms.Button();
            this.finb3 = new System.Windows.Forms.Button();
            this.fincb1 = new System.Windows.Forms.CheckBox();
            this.finl2 = new System.Windows.Forms.Label();
            this.finl3 = new System.Windows.Forms.Label();
            this.finl4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.finpb1)).BeginInit();
            this.SuspendLayout();
            // 
            // finpb1
            // 
            this.finpb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.finpb1.Location = new System.Drawing.Point(89, 116);
            this.finpb1.Name = "finpb1";
            this.finpb1.Size = new System.Drawing.Size(306, 293);
            this.finpb1.TabIndex = 0;
            this.finpb1.TabStop = false;
            // 
            // finl1
            // 
            this.finl1.AutoSize = true;
            this.finl1.BackColor = System.Drawing.Color.Transparent;
            this.finl1.Location = new System.Drawing.Point(77, 486);
            this.finl1.Name = "finl1";
            this.finl1.Size = new System.Drawing.Size(35, 13);
            this.finl1.TabIndex = 1;
            this.finl1.Text = "label1";
            // 
            // finb1
            // 
            this.finb1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finb1.Location = new System.Drawing.Point(586, 116);
            this.finb1.Name = "finb1";
            this.finb1.Size = new System.Drawing.Size(180, 38);
            this.finb1.TabIndex = 2;
            this.finb1.Text = "INITIAL";
            this.finb1.UseVisualStyleBackColor = true;
            this.finb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // finb2
            // 
            this.finb2.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finb2.Location = new System.Drawing.Point(586, 198);
            this.finb2.Name = "finb2";
            this.finb2.Size = new System.Drawing.Size(180, 39);
            this.finb2.TabIndex = 3;
            this.finb2.Text = "START CAPTURE";
            this.finb2.UseVisualStyleBackColor = true;
            this.finb2.Click += new System.EventHandler(this.button2_Click);
            // 
            // finb3
            // 
            this.finb3.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finb3.Location = new System.Drawing.Point(586, 289);
            this.finb3.Name = "finb3";
            this.finb3.Size = new System.Drawing.Size(180, 37);
            this.finb3.TabIndex = 4;
            this.finb3.Text = "STOP CAPTURE";
            this.finb3.UseVisualStyleBackColor = true;
            this.finb3.Click += new System.EventHandler(this.button3_Click);
            // 
            // fincb1
            // 
            this.fincb1.AutoSize = true;
            this.fincb1.BackColor = System.Drawing.Color.Transparent;
            this.fincb1.Location = new System.Drawing.Point(-9, 482);
            this.fincb1.Name = "fincb1";
            this.fincb1.Size = new System.Drawing.Size(80, 17);
            this.fincb1.TabIndex = 5;
            this.fincb1.Text = "checkBox1";
            this.fincb1.UseVisualStyleBackColor = false;
            this.fincb1.Visible = false;
            // 
            // finl2
            // 
            this.finl2.AutoSize = true;
            this.finl2.BackColor = System.Drawing.Color.Transparent;
            this.finl2.Location = new System.Drawing.Point(118, 486);
            this.finl2.Name = "finl2";
            this.finl2.Size = new System.Drawing.Size(35, 13);
            this.finl2.TabIndex = 6;
            this.finl2.Text = "label2";
            this.finl2.Visible = false;
            // 
            // finl3
            // 
            this.finl3.AutoSize = true;
            this.finl3.BackColor = System.Drawing.Color.Transparent;
            this.finl3.Location = new System.Drawing.Point(170, 486);
            this.finl3.Name = "finl3";
            this.finl3.Size = new System.Drawing.Size(35, 13);
            this.finl3.TabIndex = 7;
            this.finl3.Text = "label3";
            this.finl3.Visible = false;
            // 
            // finl4
            // 
            this.finl4.AutoSize = true;
            this.finl4.BackColor = System.Drawing.Color.Transparent;
            this.finl4.Location = new System.Drawing.Point(211, 486);
            this.finl4.Name = "finl4";
            this.finl4.Size = new System.Drawing.Size(35, 13);
            this.finl4.TabIndex = 8;
            this.finl4.Text = "label4";
            this.finl4.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(586, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "ONPREVIEW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.finl4);
            this.Controls.Add(this.finl3);
            this.Controls.Add(this.finl2);
            this.Controls.Add(this.fincb1);
            this.Controls.Add(this.finb3);
            this.Controls.Add(this.finb2);
            this.Controls.Add(this.finb1);
            this.Controls.Add(this.finl1);
            this.Controls.Add(this.finpb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form9";
            this.Text = "FINGERPRINT";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finpb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finpb1;
        private System.Windows.Forms.Label finl1;
        private System.Windows.Forms.Button finb1;
        private System.Windows.Forms.Button finb2;
        private System.Windows.Forms.Button finb3;
        private System.Windows.Forms.CheckBox fincb1;
        private System.Windows.Forms.Label finl2;
        private System.Windows.Forms.Label finl3;
        private System.Windows.Forms.Label finl4;
        private System.Windows.Forms.Button button1;
    }
}