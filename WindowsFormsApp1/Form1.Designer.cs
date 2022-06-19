
namespace WindowsFormsApp1
{
    partial class FormNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNew));
            this.BtnCheckInForm = new System.Windows.Forms.Button();
            this.BtnForm2 = new System.Windows.Forms.Button();
            this.btnForm3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCheckInForm
            // 
            this.BtnCheckInForm.BackColor = System.Drawing.Color.Maroon;
            this.BtnCheckInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCheckInForm.ForeColor = System.Drawing.Color.Cyan;
            this.BtnCheckInForm.Location = new System.Drawing.Point(12, 200);
            this.BtnCheckInForm.Name = "BtnCheckInForm";
            this.BtnCheckInForm.Size = new System.Drawing.Size(144, 40);
            this.BtnCheckInForm.TabIndex = 21;
            this.BtnCheckInForm.Text = "Check In Form";
            this.BtnCheckInForm.UseVisualStyleBackColor = false;
            this.BtnCheckInForm.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnForm2
            // 
            this.BtnForm2.BackColor = System.Drawing.Color.Maroon;
            this.BtnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForm2.ForeColor = System.Drawing.Color.Cyan;
            this.BtnForm2.Location = new System.Drawing.Point(331, 200);
            this.BtnForm2.Name = "BtnForm2";
            this.BtnForm2.Size = new System.Drawing.Size(81, 40);
            this.BtnForm2.TabIndex = 22;
            this.BtnForm2.Text = "Report";
            this.BtnForm2.UseVisualStyleBackColor = false;
            this.BtnForm2.Click += new System.EventHandler(this.BtnForm2_Click);
            // 
            // btnForm3
            // 
            this.btnForm3.BackColor = System.Drawing.Color.Maroon;
            this.btnForm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm3.ForeColor = System.Drawing.Color.Cyan;
            this.btnForm3.Location = new System.Drawing.Point(173, 200);
            this.btnForm3.Name = "btnForm3";
            this.btnForm3.Size = new System.Drawing.Size(140, 40);
            this.btnForm3.TabIndex = 29;
            this.btnForm3.Text = "Price Setting";
            this.btnForm3.UseVisualStyleBackColor = false;
            this.btnForm3.Click += new System.EventHandler(this.btnForm3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(146, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 34);
            this.label1.TabIndex = 30;
            this.label1.Text = "Welcome To City Zoo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.BtnCheckInForm);
            this.panel1.Controls.Add(this.btnForm3);
            this.panel1.Controls.Add(this.BtnForm2);
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 248);
            this.panel1.TabIndex = 31;
            // 
            // FormNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormNew";
            this.Text = "FormNew";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCheckInForm;
        private System.Windows.Forms.Button BtnForm2;
        private System.Windows.Forms.Button btnForm3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

