
namespace WindowsFormsApp1
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
            this.lblPriceSetting = new System.Windows.Forms.Label();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.btnForm2 = new System.Windows.Forms.Button();
            this.buttonCheckInForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAgeGroup22 = new System.Windows.Forms.TextBox();
            this.txtAgeGroup2 = new System.Windows.Forms.TextBox();
            this.txtAgeGroup11 = new System.Windows.Forms.TextBox();
            this.txtAgeGroup1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbDuration = new System.Windows.Forms.ComboBox();
            this.cmbGroupOf = new System.Windows.Forms.ComboBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblGroupOf = new System.Windows.Forms.Label();
            this.lblAgeGroup2 = new System.Windows.Forms.Label();
            this.lblAgeGroup1 = new System.Windows.Forms.Label();
            this.lblWeekEnds = new System.Windows.Forms.Label();
            this.lblWeekdays = new System.Windows.Forms.Label();
            this.lblAgeGroup = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPriceSetting
            // 
            this.lblPriceSetting.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPriceSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceSetting.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPriceSetting.Location = new System.Drawing.Point(379, 9);
            this.lblPriceSetting.Name = "lblPriceSetting";
            this.lblPriceSetting.Size = new System.Drawing.Size(199, 34);
            this.lblPriceSetting.TabIndex = 0;
            this.lblPriceSetting.Text = "Ticket Rates";
            this.lblPriceSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPriceSetting.Click += new System.EventHandler(this.lblPriceSetting_Click);
            // 
            // btnForm1
            // 
            this.btnForm1.BackColor = System.Drawing.Color.Gray;
            this.btnForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm1.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnForm1.Location = new System.Drawing.Point(798, 331);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(70, 31);
            this.btnForm1.TabIndex = 19;
            this.btnForm1.Text = "Home";
            this.btnForm1.UseVisualStyleBackColor = false;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // btnForm2
            // 
            this.btnForm2.BackColor = System.Drawing.Color.Gray;
            this.btnForm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm2.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnForm2.Location = new System.Drawing.Point(874, 330);
            this.btnForm2.Name = "btnForm2";
            this.btnForm2.Size = new System.Drawing.Size(70, 32);
            this.btnForm2.TabIndex = 20;
            this.btnForm2.Text = "Report";
            this.btnForm2.UseVisualStyleBackColor = false;
            this.btnForm2.Click += new System.EventHandler(this.btnForm2_Click);
            // 
            // buttonCheckInForm
            // 
            this.buttonCheckInForm.BackColor = System.Drawing.Color.Gray;
            this.buttonCheckInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckInForm.ForeColor = System.Drawing.Color.Aquamarine;
            this.buttonCheckInForm.Location = new System.Drawing.Point(675, 332);
            this.buttonCheckInForm.Name = "buttonCheckInForm";
            this.buttonCheckInForm.Size = new System.Drawing.Size(117, 31);
            this.buttonCheckInForm.TabIndex = 21;
            this.buttonCheckInForm.Text = "Check In Form";
            this.buttonCheckInForm.UseVisualStyleBackColor = false;
            this.buttonCheckInForm.Click += new System.EventHandler(this.buttonCheckInForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtAgeGroup22);
            this.panel1.Controls.Add(this.txtAgeGroup2);
            this.panel1.Controls.Add(this.txtAgeGroup11);
            this.panel1.Controls.Add(this.txtAgeGroup1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.cmbDuration);
            this.panel1.Controls.Add(this.cmbGroupOf);
            this.panel1.Controls.Add(this.lblDuration);
            this.panel1.Controls.Add(this.lblGroupOf);
            this.panel1.Controls.Add(this.lblAgeGroup2);
            this.panel1.Controls.Add(this.lblAgeGroup1);
            this.panel1.Controls.Add(this.lblWeekEnds);
            this.panel1.Controls.Add(this.lblWeekdays);
            this.panel1.Controls.Add(this.lblAgeGroup);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 280);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Gray;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.Color.Aquamarine;
            this.buttonUpdate.Location = new System.Drawing.Point(135, 250);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(68, 29);
            this.buttonUpdate.TabIndex = 39;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(550, 162);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtAgeGroup22
            // 
            this.txtAgeGroup22.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAgeGroup22.Location = new System.Drawing.Point(293, 117);
            this.txtAgeGroup22.Name = "txtAgeGroup22";
            this.txtAgeGroup22.Size = new System.Drawing.Size(95, 20);
            this.txtAgeGroup22.TabIndex = 37;
            // 
            // txtAgeGroup2
            // 
            this.txtAgeGroup2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAgeGroup2.Location = new System.Drawing.Point(135, 114);
            this.txtAgeGroup2.Name = "txtAgeGroup2";
            this.txtAgeGroup2.Size = new System.Drawing.Size(95, 20);
            this.txtAgeGroup2.TabIndex = 36;
            this.txtAgeGroup2.TextChanged += new System.EventHandler(this.txtAgeGroup2_TextChanged);
            // 
            // txtAgeGroup11
            // 
            this.txtAgeGroup11.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAgeGroup11.Location = new System.Drawing.Point(293, 75);
            this.txtAgeGroup11.Name = "txtAgeGroup11";
            this.txtAgeGroup11.Size = new System.Drawing.Size(95, 20);
            this.txtAgeGroup11.TabIndex = 35;
            // 
            // txtAgeGroup1
            // 
            this.txtAgeGroup1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAgeGroup1.Location = new System.Drawing.Point(136, 72);
            this.txtAgeGroup1.Name = "txtAgeGroup1";
            this.txtAgeGroup1.Size = new System.Drawing.Size(95, 20);
            this.txtAgeGroup1.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnClear.Location = new System.Drawing.Point(74, 251);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(55, 26);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Gray;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit.Location = new System.Drawing.Point(3, 249);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(65, 28);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // cmbDuration
            // 
            this.cmbDuration.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbDuration.FormattingEnabled = true;
            this.cmbDuration.Items.AddRange(new object[] {
            "1 Hrs",
            "2 Hrs",
            "3 Hrs",
            "4 Hrs",
            "Whole Day"});
            this.cmbDuration.Location = new System.Drawing.Point(74, 209);
            this.cmbDuration.Name = "cmbDuration";
            this.cmbDuration.Size = new System.Drawing.Size(73, 21);
            this.cmbDuration.TabIndex = 31;
            // 
            // cmbGroupOf
            // 
            this.cmbGroupOf.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.cmbGroupOf.FormattingEnabled = true;
            this.cmbGroupOf.Items.AddRange(new object[] {
            "Group Of 5",
            "Group Of 10",
            "Group Of 15"});
            this.cmbGroupOf.Location = new System.Drawing.Point(74, 167);
            this.cmbGroupOf.Name = "cmbGroupOf";
            this.cmbGroupOf.Size = new System.Drawing.Size(73, 21);
            this.cmbGroupOf.TabIndex = 30;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(5, 211);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(56, 15);
            this.lblDuration.TabIndex = 29;
            this.lblDuration.Text = "Duration";
            // 
            // lblGroupOf
            // 
            this.lblGroupOf.AutoSize = true;
            this.lblGroupOf.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupOf.Location = new System.Drawing.Point(3, 169);
            this.lblGroupOf.Name = "lblGroupOf";
            this.lblGroupOf.Size = new System.Drawing.Size(58, 15);
            this.lblGroupOf.TabIndex = 28;
            this.lblGroupOf.Text = "Group Of";
            // 
            // lblAgeGroup2
            // 
            this.lblAgeGroup2.AutoSize = true;
            this.lblAgeGroup2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeGroup2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAgeGroup2.Location = new System.Drawing.Point(3, 118);
            this.lblAgeGroup2.Name = "lblAgeGroup2";
            this.lblAgeGroup2.Size = new System.Drawing.Size(65, 16);
            this.lblAgeGroup2.TabIndex = 27;
            this.lblAgeGroup2.Text = "Adult > 12";
            // 
            // lblAgeGroup1
            // 
            this.lblAgeGroup1.AutoSize = true;
            this.lblAgeGroup1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeGroup1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAgeGroup1.Location = new System.Drawing.Point(3, 75);
            this.lblAgeGroup1.Name = "lblAgeGroup1";
            this.lblAgeGroup1.Size = new System.Drawing.Size(74, 16);
            this.lblAgeGroup1.TabIndex = 26;
            this.lblAgeGroup1.Text = "Child (5-12)";
            // 
            // lblWeekEnds
            // 
            this.lblWeekEnds.AutoSize = true;
            this.lblWeekEnds.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekEnds.Location = new System.Drawing.Point(290, 28);
            this.lblWeekEnds.Name = "lblWeekEnds";
            this.lblWeekEnds.Size = new System.Drawing.Size(77, 17);
            this.lblWeekEnds.TabIndex = 25;
            this.lblWeekEnds.Text = "Weekends";
            // 
            // lblWeekdays
            // 
            this.lblWeekdays.AutoSize = true;
            this.lblWeekdays.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeekdays.Location = new System.Drawing.Point(133, 24);
            this.lblWeekdays.Name = "lblWeekdays";
            this.lblWeekdays.Size = new System.Drawing.Size(75, 17);
            this.lblWeekdays.TabIndex = 24;
            this.lblWeekdays.Text = "Weekdays";
            // 
            // lblAgeGroup
            // 
            this.lblAgeGroup.AutoSize = true;
            this.lblAgeGroup.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgeGroup.Location = new System.Drawing.Point(3, 24);
            this.lblAgeGroup.Name = "lblAgeGroup";
            this.lblAgeGroup.Size = new System.Drawing.Size(80, 17);
            this.lblAgeGroup.TabIndex = 23;
            this.lblAgeGroup.Text = "Age Group";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(956, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonCheckInForm);
            this.Controls.Add(this.btnForm2);
            this.Controls.Add(this.btnForm1);
            this.Controls.Add(this.lblPriceSetting);
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPriceSetting;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Button btnForm2;
        private System.Windows.Forms.Button buttonCheckInForm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAgeGroup22;
        private System.Windows.Forms.TextBox txtAgeGroup2;
        private System.Windows.Forms.TextBox txtAgeGroup11;
        private System.Windows.Forms.TextBox txtAgeGroup1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbDuration;
        private System.Windows.Forms.ComboBox cmbGroupOf;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblGroupOf;
        private System.Windows.Forms.Label lblAgeGroup2;
        private System.Windows.Forms.Label lblAgeGroup1;
        private System.Windows.Forms.Label lblWeekEnds;
        private System.Windows.Forms.Label lblWeekdays;
        private System.Windows.Forms.Label lblAgeGroup;
        private System.Windows.Forms.Button buttonUpdate;
    }
}