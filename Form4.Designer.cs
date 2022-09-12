namespace WindowsFormsApplication4
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.wdt1 = new System.Windows.Forms.TextBox();
            this.wdb1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.wdb2 = new System.Windows.Forms.Button();
            this.wdl3 = new System.Windows.Forms.Label();
            this.wdl1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wdt1
            // 
            this.wdt1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdt1.Location = new System.Drawing.Point(366, 276);
            this.wdt1.Name = "wdt1";
            this.wdt1.Size = new System.Drawing.Size(180, 21);
            this.wdt1.TabIndex = 0;
            this.wdt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // wdb1
            // 
            this.wdb1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdb1.Location = new System.Drawing.Point(251, 366);
            this.wdb1.Name = "wdb1";
            this.wdb1.Size = new System.Drawing.Size(180, 40);
            this.wdb1.TabIndex = 1;
            this.wdb1.Text = "OK";
            this.wdb1.UseVisualStyleBackColor = true;
            this.wdb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // wdb2
            // 
            this.wdb2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdb2.Location = new System.Drawing.Point(501, 366);
            this.wdb2.Name = "wdb2";
            this.wdb2.Size = new System.Drawing.Size(180, 40);
            this.wdb2.TabIndex = 4;
            this.wdb2.Text = "CANCEL";
            this.wdb2.UseVisualStyleBackColor = true;
            this.wdb2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wdl3
            // 
            this.wdl3.AutoSize = true;
            this.wdl3.BackColor = System.Drawing.Color.Transparent;
            this.wdl3.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wdl3.Location = new System.Drawing.Point(361, 192);
            this.wdl3.Name = "wdl3";
            this.wdl3.Size = new System.Drawing.Size(195, 30);
            this.wdl3.TabIndex = 5;
            this.wdl3.Text = "ENTER AMOUNT";
            // 
            // wdl1
            // 
            this.wdl1.AutoSize = true;
            this.wdl1.Location = new System.Drawing.Point(12, 9);
            this.wdl1.Name = "wdl1";
            this.wdl1.Size = new System.Drawing.Size(35, 13);
            this.wdl1.TabIndex = 6;
            this.wdl1.Text = "label4";
            this.wdl1.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(366, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wdl1);
            this.Controls.Add(this.wdl3);
            this.Controls.Add(this.wdb2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wdb1);
            this.Controls.Add(this.wdt1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form4";
            this.Text = "WITHDRAWAL";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wdt1;
        private System.Windows.Forms.Button wdb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button wdb2;
        private System.Windows.Forms.Label wdl3;
        private System.Windows.Forms.Label wdl1;
        private System.Windows.Forms.Button button1;
    }
}