namespace WindowsFormsApplication4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.logt1 = new System.Windows.Forms.TextBox();
            this.logt2 = new System.Windows.Forms.TextBox();
            this.logb2 = new System.Windows.Forms.Button();
            this.logl2 = new System.Windows.Forms.Label();
            this.logl1 = new System.Windows.Forms.Label();
            this.logb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logt1
            // 
            this.logt1.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logt1.Location = new System.Drawing.Point(557, 157);
            this.logt1.Margin = new System.Windows.Forms.Padding(4);
            this.logt1.Name = "logt1";
            this.logt1.Size = new System.Drawing.Size(180, 23);
            this.logt1.TabIndex = 1;
            // 
            // logt2
            // 
            this.logt2.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logt2.Location = new System.Drawing.Point(557, 279);
            this.logt2.Margin = new System.Windows.Forms.Padding(4);
            this.logt2.Name = "logt2";
            this.logt2.Size = new System.Drawing.Size(180, 23);
            this.logt2.TabIndex = 2;
            this.logt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logb2
            // 
            this.logb2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logb2.Location = new System.Drawing.Point(557, 399);
            this.logb2.Margin = new System.Windows.Forms.Padding(4);
            this.logb2.Name = "logb2";
            this.logb2.Size = new System.Drawing.Size(180, 40);
            this.logb2.TabIndex = 3;
            this.logb2.Text = "CANCEL";
            this.logb2.UseVisualStyleBackColor = true;
            this.logb2.Click += new System.EventHandler(this.button2_Click);
            // 
            // logl2
            // 
            this.logl2.AutoSize = true;
            this.logl2.BackColor = System.Drawing.Color.Transparent;
            this.logl2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logl2.Location = new System.Drawing.Point(198, 279);
            this.logl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logl2.Name = "logl2";
            this.logl2.Size = new System.Drawing.Size(270, 27);
            this.logl2.TabIndex = 4;
            this.logl2.Text = "ENTER YOUR PASSWORD";
            // 
            // logl1
            // 
            this.logl1.AutoSize = true;
            this.logl1.BackColor = System.Drawing.Color.Transparent;
            this.logl1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logl1.ForeColor = System.Drawing.Color.Black;
            this.logl1.Location = new System.Drawing.Point(198, 153);
            this.logl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logl1.Name = "logl1";
            this.logl1.Size = new System.Drawing.Size(209, 27);
            this.logl1.TabIndex = 5;
            this.logl1.Text = "ENTER YOUR NAME\r\n";
            this.logl1.Click += new System.EventHandler(this.label2_Click);
            // 
            // logb1
            // 
            this.logb1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logb1.Location = new System.Drawing.Point(203, 399);
            this.logb1.Margin = new System.Windows.Forms.Padding(4);
            this.logb1.Name = "logb1";
            this.logb1.Size = new System.Drawing.Size(180, 40);
            this.logb1.TabIndex = 0;
            this.logb1.Text = "OK";
            this.logb1.UseVisualStyleBackColor = true;
            this.logb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.logl1);
            this.Controls.Add(this.logl2);
            this.Controls.Add(this.logb2);
            this.Controls.Add(this.logt2);
            this.Controls.Add(this.logt1);
            this.Controls.Add(this.logb1);
            this.Font = new System.Drawing.Font("Stencil", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logt1;
        private System.Windows.Forms.TextBox logt2;
        private System.Windows.Forms.Button logb2;
        private System.Windows.Forms.Label logl2;
        private System.Windows.Forms.Label logl1;
        private System.Windows.Forms.Button logb1;
    }
}

