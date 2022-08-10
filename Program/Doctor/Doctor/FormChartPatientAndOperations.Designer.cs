namespace Doctor
{
    partial class FormChartPatientAndOperations
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patoprPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientOperations = new Doctor.DataSetPatientOperations();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPatientOperationsTableAdapter = new Doctor.DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 45);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "ניתוחים";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(540, 337);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patoprPatiIDDataGridViewTextBoxColumn,
            this.patoprNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(558, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(243, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // patoprPatiIDDataGridViewTextBoxColumn
            // 
            this.patoprPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patoprPatiID";
            this.patoprPatiIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.patoprPatiIDDataGridViewTextBoxColumn.Name = "patoprPatiIDDataGridViewTextBoxColumn";
            this.patoprPatiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patoprNameDataGridViewTextBoxColumn
            // 
            this.patoprNameDataGridViewTextBoxColumn.DataPropertyName = "patoprName";
            this.patoprNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.patoprNameDataGridViewTextBoxColumn.Name = "patoprNameDataGridViewTextBoxColumn";
            this.patoprNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientOperationsBindingSource
            // 
            this.tblPatientOperationsBindingSource.DataMember = "tblPatientOperations";
            this.tblPatientOperationsBindingSource.DataSource = this.dataSetPatientOperations;
            // 
            // dataSetPatientOperations
            // 
            this.dataSetPatientOperations.DataSetName = "DataSetPatientOperations";
            this.dataSetPatientOperations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(572, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "התפלגות ניתוחים";
            // 
            // tblPatientOperationsTableAdapter
            // 
            this.tblPatientOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // FormChartPatientAndOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "FormChartPatientAndOperations";
            this.Text = "FormChartPatientAndOperations";
            this.Load += new System.EventHandler(this.FormChartPatientAndOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSetPatientOperations dataSetPatientOperations;
        private System.Windows.Forms.BindingSource tblPatientOperationsBindingSource;
        private DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter tblPatientOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprNameDataGridViewTextBoxColumn;
    }
}