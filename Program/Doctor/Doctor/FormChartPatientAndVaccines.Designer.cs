﻿namespace Doctor
{
    partial class FormChartPatientAndVaccines
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patvacPatientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientVaccines = new Doctor.DataSetPatientVaccines();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tblPatientVaccinesTableAdapter = new Doctor.DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(570, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "התפלגות חיסונים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patvacPatientIDDataGridViewTextBoxColumn,
            this.patvacNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(243, 337);
            this.dataGridView1.TabIndex = 7;
            // 
            // patvacPatientIDDataGridViewTextBoxColumn
            // 
            this.patvacPatientIDDataGridViewTextBoxColumn.DataPropertyName = "patvacPatientID";
            this.patvacPatientIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.patvacPatientIDDataGridViewTextBoxColumn.Name = "patvacPatientIDDataGridViewTextBoxColumn";
            this.patvacPatientIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patvacNameDataGridViewTextBoxColumn
            // 
            this.patvacNameDataGridViewTextBoxColumn.DataPropertyName = "patvacName";
            this.patvacNameDataGridViewTextBoxColumn.HeaderText = "שם חיסון";
            this.patvacNameDataGridViewTextBoxColumn.Name = "patvacNameDataGridViewTextBoxColumn";
            this.patvacNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientVaccinesBindingSource
            // 
            this.tblPatientVaccinesBindingSource.DataMember = "tblPatientVaccines";
            this.tblPatientVaccinesBindingSource.DataSource = this.dataSetPatientVaccines;
            // 
            // dataSetPatientVaccines
            // 
            this.dataSetPatientVaccines.DataSetName = "DataSetPatientVaccines";
            this.dataSetPatientVaccines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 47);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "חיסונים";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(540, 337);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // tblPatientVaccinesTableAdapter
            // 
            this.tblPatientVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // FormChartPatientAndVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "FormChartPatientAndVaccines";
            this.Text = "FormChartPatientAndVaccines";
            this.Load += new System.EventHandler(this.FormChartPatientAndVaccines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataSetPatientVaccines dataSetPatientVaccines;
        private System.Windows.Forms.BindingSource tblPatientVaccinesBindingSource;
        private DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter tblPatientVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacPatientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacNameDataGridViewTextBoxColumn;
    }
}