namespace Doctor
{
    partial class FormChartPatientAndDiseases
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataSetDiseases = new Doctor.DataSetDiseases();
            this.tblDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDiseasesTableAdapter = new Doctor.DataSetDiseasesTableAdapters.tblDiseasesTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patdssPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDiseases = new Doctor.DataSetPatientDiseases();
            this.tblPatientDiseasesTableAdapter = new Doctor.DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(570, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "התפלגות מחלות";
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
            series1.Name = "מחלות";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(540, 337);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // dataSetDiseases
            // 
            this.dataSetDiseases.DataSetName = "DataSetDiseases";
            this.dataSetDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDiseasesBindingSource
            // 
            this.tblDiseasesBindingSource.DataMember = "tblDiseases";
            this.tblDiseasesBindingSource.DataSource = this.dataSetDiseases;
            // 
            // tblDiseasesTableAdapter
            // 
            this.tblDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patdssPatiIDDataGridViewTextBoxColumn,
            this.patdssNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(556, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(245, 337);
            this.dataGridView1.TabIndex = 9;
            // 
            // patdssPatiIDDataGridViewTextBoxColumn
            // 
            this.patdssPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdssPatiID";
            this.patdssPatiIDDataGridViewTextBoxColumn.HeaderText = "תז";
            this.patdssPatiIDDataGridViewTextBoxColumn.Name = "patdssPatiIDDataGridViewTextBoxColumn";
            this.patdssPatiIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patdssNameDataGridViewTextBoxColumn
            // 
            this.patdssNameDataGridViewTextBoxColumn.DataPropertyName = "patdssName";
            this.patdssNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.patdssNameDataGridViewTextBoxColumn.Name = "patdssNameDataGridViewTextBoxColumn";
            this.patdssNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblPatientDiseasesBindingSource
            // 
            this.tblPatientDiseasesBindingSource.DataMember = "tblPatientDiseases";
            this.tblPatientDiseasesBindingSource.DataSource = this.dataSetPatientDiseases;
            // 
            // dataSetPatientDiseases
            // 
            this.dataSetPatientDiseases.DataSetName = "DataSetPatientDiseases";
            this.dataSetPatientDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPatientDiseasesTableAdapter
            // 
            this.tblPatientDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormChartPatientAndDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "FormChartPatientAndDiseases";
            this.Text = "FormChartPatientAndDiseases";
            this.Load += new System.EventHandler(this.FormChartPatientAndDiseases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DataSetDiseases dataSetDiseases;
        private System.Windows.Forms.BindingSource tblDiseasesBindingSource;
        private DataSetDiseasesTableAdapters.tblDiseasesTableAdapter tblDiseasesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPatientDiseases dataSetPatientDiseases;
        private System.Windows.Forms.BindingSource tblPatientDiseasesBindingSource;
        private DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter tblPatientDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssNameDataGridViewTextBoxColumn;
    }
}