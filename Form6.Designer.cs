namespace WindowsFormsApplication4
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.dpb1 = new System.Windows.Forms.Button();
            this.dpt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dp1 = new System.Windows.Forms.Label();
            this.dpb2 = new System.Windows.Forms.Button();
            this.dp2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dpb1
            // 
            this.dpb1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpb1.Location = new System.Drawing.Point(217, 329);
            this.dpb1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dpb1.Name = "dpb1";
            this.dpb1.Size = new System.Drawing.Size(180, 45);
            this.dpb1.TabIndex = 0;
            this.dpb1.Text = "OK";
            this.dpb1.UseVisualStyleBackColor = true;
            this.dpb1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dpt1
            // 
            this.dpt1.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpt1.Location = new System.Drawing.Point(371, 245);
            this.dpt1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dpt1.Name = "dpt1";
            this.dpt1.Size = new System.Drawing.Size(180, 25);
            this.dpt1.TabIndex = 1;
            this.dpt1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dp1
            // 
            this.dp1.AutoSize = true;
            this.dp1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp1.Location = new System.Drawing.Point(29, 27);
            this.dp1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dp1.Name = "dp1";
            this.dp1.Size = new System.Drawing.Size(45, 13);
            this.dp1.TabIndex = 3;
            this.dp1.Text = "label2";
            this.dp1.Visible = false;
            // 
            // dpb2
            // 
            this.dpb2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpb2.Location = new System.Drawing.Point(526, 329);
            this.dpb2.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.dpb2.Name = "dpb2";
            this.dpb2.Size = new System.Drawing.Size(180, 45);
            this.dpb2.TabIndex = 4;
            this.dpb2.Text = "CANCEL";
            this.dpb2.UseVisualStyleBackColor = true;
            this.dpb2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dp2
            // 
            this.dp2.AutoSize = true;
            this.dp2.BackColor = System.Drawing.Color.Transparent;
            this.dp2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp2.Location = new System.Drawing.Point(342, 172);
            this.dp2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.dp2.Name = "dp2";
            this.dp2.Size = new System.Drawing.Size(272, 27);
            this.dp2.TabIndex = 5;
            this.dp2.Text = "ENTER AMOUNT DEPOSIT";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 424);
            this.button1.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dp2);
            this.Controls.Add(this.dpb2);
            this.Controls.Add(this.dp1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpt1);
            this.Controls.Add(this.dpb1);
            this.Font = new System.Drawing.Font("Stencil", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "Form6";
            this.Text = "DEPOSIT";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dpb1;
        private System.Windows.Forms.TextBox dpt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dp1;
        private System.Windows.Forms.Button dpb2;
        private System.Windows.Forms.Label dp2;
        private System.Windows.Forms.Button button1;
    }
}