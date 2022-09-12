namespace WindowsFormsApplication4
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.label1 = new System.Windows.Forms.Label();
            this.ball1 = new System.Windows.Forms.Label();
            this.ball3 = new System.Windows.Forms.Label();
            this.ball2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // ball1
            // 
            this.ball1.AutoSize = true;
            this.ball1.BackColor = System.Drawing.Color.Transparent;
            this.ball1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball1.Location = new System.Drawing.Point(37, 35);
            this.ball1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(45, 13);
            this.ball1.TabIndex = 1;
            this.ball1.Text = "label2";
            this.ball1.Visible = false;
            this.ball1.Click += new System.EventHandler(this.label2_Click);
            // 
            // ball3
            // 
            this.ball3.AutoSize = true;
            this.ball3.BackColor = System.Drawing.Color.Transparent;
            this.ball3.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball3.Location = new System.Drawing.Point(506, 230);
            this.ball3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ball3.Name = "ball3";
            this.ball3.Size = new System.Drawing.Size(86, 30);
            this.ball3.TabIndex = 2;
            this.ball3.Text = "label3";
            this.ball3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ball2
            // 
            this.ball2.AutoSize = true;
            this.ball2.BackColor = System.Drawing.Color.Transparent;
            this.ball2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ball2.Location = new System.Drawing.Point(274, 230);
            this.ball2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.ball2.Name = "ball2";
            this.ball2.Size = new System.Drawing.Size(232, 30);
            this.ball2.TabIndex = 3;
            this.ball2.Text = "YOUR BALANCE IS:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ball2);
            this.Controls.Add(this.ball3);
            this.Controls.Add(this.ball1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Stencil", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Form7";
            this.Text = "BALANCE";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ball1;
        private System.Windows.Forms.Label ball3;
        private System.Windows.Forms.Label ball2;
        private System.Windows.Forms.Button button1;
    }
}