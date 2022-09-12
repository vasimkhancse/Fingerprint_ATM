namespace WindowsFormsApplication4
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.tral1 = new System.Windows.Forms.Label();
            this.tral2 = new System.Windows.Forms.Label();
            this.trab1 = new System.Windows.Forms.Button();
            this.trab2 = new System.Windows.Forms.Button();
            this.trab3 = new System.Windows.Forms.Button();
            this.trab4 = new System.Windows.Forms.Button();
            this.trab5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tral1
            // 
            this.tral1.AutoSize = true;
            this.tral1.Location = new System.Drawing.Point(12, 9);
            this.tral1.Name = "tral1";
            this.tral1.Size = new System.Drawing.Size(35, 13);
            this.tral1.TabIndex = 0;
            this.tral1.Text = "label1";
            this.tral1.Visible = false;
            // 
            // tral2
            // 
            this.tral2.AutoSize = true;
            this.tral2.Location = new System.Drawing.Point(12, 22);
            this.tral2.Name = "tral2";
            this.tral2.Size = new System.Drawing.Size(35, 13);
            this.tral2.TabIndex = 1;
            this.tral2.Text = "label2";
            this.tral2.Visible = false;
            // 
            // trab1
            // 
            this.trab1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trab1.Location = new System.Drawing.Point(303, 78);
            this.trab1.Name = "trab1";
            this.trab1.Size = new System.Drawing.Size(212, 46);
            this.trab1.TabIndex = 2;
            this.trab1.Text = "WITHDRAWAL\r\n";
            this.trab1.UseVisualStyleBackColor = true;
            this.trab1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trab2
            // 
            this.trab2.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trab2.Location = new System.Drawing.Point(303, 173);
            this.trab2.Name = "trab2";
            this.trab2.Size = new System.Drawing.Size(212, 46);
            this.trab2.TabIndex = 3;
            this.trab2.Text = "PIN CHANGE";
            this.trab2.UseVisualStyleBackColor = true;
            this.trab2.Click += new System.EventHandler(this.button2_Click);
            // 
            // trab3
            // 
            this.trab3.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trab3.Location = new System.Drawing.Point(303, 283);
            this.trab3.Name = "trab3";
            this.trab3.Size = new System.Drawing.Size(212, 46);
            this.trab3.TabIndex = 4;
            this.trab3.Text = "DEPOSIT";
            this.trab3.UseVisualStyleBackColor = true;
            this.trab3.Click += new System.EventHandler(this.button3_Click);
            // 
            // trab4
            // 
            this.trab4.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trab4.Location = new System.Drawing.Point(303, 381);
            this.trab4.Name = "trab4";
            this.trab4.Size = new System.Drawing.Size(212, 46);
            this.trab4.TabIndex = 5;
            this.trab4.Text = "BALANCE";
            this.trab4.UseVisualStyleBackColor = true;
            this.trab4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trab5
            // 
            this.trab5.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trab5.Location = new System.Drawing.Point(303, 474);
            this.trab5.Name = "trab5";
            this.trab5.Size = new System.Drawing.Size(212, 46);
            this.trab5.TabIndex = 6;
            this.trab5.Text = "USER DETAIL";
            this.trab5.UseVisualStyleBackColor = true;
            this.trab5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.trab5);
            this.Controls.Add(this.trab4);
            this.Controls.Add(this.trab3);
            this.Controls.Add(this.trab2);
            this.Controls.Add(this.trab1);
            this.Controls.Add(this.tral2);
            this.Controls.Add(this.tral1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.Text = "TRANSACTION";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tral1;
        private System.Windows.Forms.Label tral2;
        private System.Windows.Forms.Button trab1;
        private System.Windows.Forms.Button trab2;
        private System.Windows.Forms.Button trab3;
        private System.Windows.Forms.Button trab4;
        private System.Windows.Forms.Button trab5;
    }
}