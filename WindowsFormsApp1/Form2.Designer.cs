
namespace WindowsFormsApp1
{
    partial class Formback
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit1 = new System.Windows.Forms.Button();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnForm1 = new System.Windows.Forms.Button();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.lblWeeklyReport = new System.Windows.Forms.Label();
            this.btnPriceSetting = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckInForm = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(126, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(522, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSubmit1
            // 
            this.btnSubmit1.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit1.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit1.Location = new System.Drawing.Point(12, 160);
            this.btnSubmit1.Name = "btnSubmit1";
            this.btnSubmit1.Size = new System.Drawing.Size(112, 32);
            this.btnSubmit1.TabIndex = 1;
            this.btnSubmit1.Text = "View Report";
            this.btnSubmit1.UseVisualStyleBackColor = false;
            this.btnSubmit1.Click += new System.EventHandler(this.btnSubmit1_Click);
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.BackColor = System.Drawing.Color.DimGray;
            this.btnSubmit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit2.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnSubmit2.Location = new System.Drawing.Point(12, 331);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(112, 33);
            this.btnSubmit2.TabIndex = 2;
            this.btnSubmit2.Text = "View Report";
            this.btnSubmit2.UseVisualStyleBackColor = false;
            this.btnSubmit2.Click += new System.EventHandler(this.btnSubmit2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(126, 212);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(522, 152);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnForm1
            // 
            this.btnForm1.BackColor = System.Drawing.Color.DimGray;
            this.btnForm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForm1.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnForm1.Location = new System.Drawing.Point(762, 4);
            this.btnForm1.Name = "btnForm1";
            this.btnForm1.Size = new System.Drawing.Size(85, 30);
            this.btnForm1.TabIndex = 4;
            this.btnForm1.Text = "Home";
            this.btnForm1.UseVisualStyleBackColor = false;
            this.btnForm1.Click += new System.EventHandler(this.btnForm1_Click);
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyReport.Location = new System.Drawing.Point(12, 39);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(108, 20);
            this.lblDailyReport.TabIndex = 5;
            this.lblDailyReport.Text = "Daily Report";
            // 
            // lblWeeklyReport
            // 
            this.lblWeeklyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeeklyReport.Location = new System.Drawing.Point(-2, 210);
            this.lblWeeklyReport.Name = "lblWeeklyReport";
            this.lblWeeklyReport.Size = new System.Drawing.Size(126, 31);
            this.lblWeeklyReport.TabIndex = 6;
            this.lblWeeklyReport.Text = "Weekly Report";
            // 
            // btnPriceSetting
            // 
            this.btnPriceSetting.BackColor = System.Drawing.Color.DimGray;
            this.btnPriceSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPriceSetting.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnPriceSetting.Location = new System.Drawing.Point(853, 4);
            this.btnPriceSetting.Name = "btnPriceSetting";
            this.btnPriceSetting.Size = new System.Drawing.Size(109, 30);
            this.btnPriceSetting.TabIndex = 7;
            this.btnPriceSetting.Text = "Price Setting";
            this.btnPriceSetting.UseVisualStyleBackColor = false;
            this.btnPriceSetting.Click += new System.EventHandler(this.btnPriceSetting_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(429, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckInForm
            // 
            this.btnCheckInForm.BackColor = System.Drawing.Color.DimGray;
            this.btnCheckInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInForm.ForeColor = System.Drawing.Color.Aquamarine;
            this.btnCheckInForm.Location = new System.Drawing.Point(632, 4);
            this.btnCheckInForm.Name = "btnCheckInForm";
            this.btnCheckInForm.Size = new System.Drawing.Size(124, 30);
            this.btnCheckInForm.TabIndex = 9;
            this.btnCheckInForm.Text = "Check In Form";
            this.btnCheckInForm.UseVisualStyleBackColor = false;
            this.btnCheckInForm.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(654, 42);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(309, 137);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(654, 212);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(309, 148);
            this.chart2.TabIndex = 11;
            this.chart2.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 37);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btnPriceSetting);
            this.panel2.Controls.Add(this.btnForm1);
            this.panel2.Controls.Add(this.btnCheckInForm);
            this.panel2.Location = new System.Drawing.Point(1, 414);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 37);
            this.panel2.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Sort by price"});
            this.comboBox1.Location = new System.Drawing.Point(864, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(98, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Formback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblWeeklyReport);
            this.Controls.Add(this.lblDailyReport);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnSubmit2);
            this.Controls.Add(this.btnSubmit1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Formback";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Formback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubmit1;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnForm1;
        private System.Windows.Forms.Label lblDailyReport;
        private System.Windows.Forms.Label lblWeeklyReport;
        private System.Windows.Forms.Button btnPriceSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheckInForm;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}