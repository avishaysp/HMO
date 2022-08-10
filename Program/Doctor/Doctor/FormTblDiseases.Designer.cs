namespace Doctor
{
    partial class FormTblDiseases
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diseaseRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDiseases = new Doctor.DataSetDiseases();
            this.label1 = new System.Windows.Forms.Label();
            this.tblDiseasesTableAdapter = new Doctor.DataSetDiseasesTableAdapters.tblDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseRegNameDataGridViewTextBoxColumn,
            this.diseaseSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(236, 269);
            this.dataGridView1.TabIndex = 1;
            // 
            // diseaseRegNameDataGridViewTextBoxColumn
            // 
            this.diseaseRegNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseRegName";
            this.diseaseRegNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.diseaseRegNameDataGridViewTextBoxColumn.Name = "diseaseRegNameDataGridViewTextBoxColumn";
            // 
            // diseaseSciNameDataGridViewTextBoxColumn
            // 
            this.diseaseSciNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseSciName";
            this.diseaseSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.diseaseSciNameDataGridViewTextBoxColumn.Name = "diseaseSciNameDataGridViewTextBoxColumn";
            // 
            // tblDiseasesBindingSource
            // 
            this.tblDiseasesBindingSource.DataMember = "tblDiseases";
            this.tblDiseasesBindingSource.DataSource = this.dataSetDiseases;
            // 
            // dataSetDiseases
            // 
            this.dataSetDiseases.DataSetName = "DataSetDiseases";
            this.dataSetDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת מחלות";
            // 
            // tblDiseasesTableAdapter
            // 
            this.tblDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormTblDiseases";
            this.Text = "FormTblDiseases";
            this.Load += new System.EventHandler(this.FormTblDiseases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSetDiseases dataSetDiseases;
        private System.Windows.Forms.BindingSource tblDiseasesBindingSource;
        private DataSetDiseasesTableAdapters.tblDiseasesTableAdapter tblDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseSciNameDataGridViewTextBoxColumn;
    }
}