namespace Doctor
{
    partial class FormTblPatientDiseases
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPatientDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDiseases = new Doctor.DataSetPatientDiseases();
            this.button1 = new System.Windows.Forms.Button();
            this.tblPatientDiseasesTableAdapter = new Doctor.DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter();
            this.patdssIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(168, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת מחלות למטופל";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patdssIDDataGridViewTextBoxColumn,
            this.patdssPatiIDDataGridViewTextBoxColumn,
            this.patdssDateDataGridViewTextBoxColumn,
            this.patdssNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(696, 267);
            this.dataGridView1.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblPatientDiseasesTableAdapter
            // 
            this.tblPatientDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // patdssIDDataGridViewTextBoxColumn
            // 
            this.patdssIDDataGridViewTextBoxColumn.DataPropertyName = "patdssID";
            this.patdssIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patdssIDDataGridViewTextBoxColumn.Name = "patdssIDDataGridViewTextBoxColumn";
            // 
            // patdssPatiIDDataGridViewTextBoxColumn
            // 
            this.patdssPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdssPatiID";
            this.patdssPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patdssPatiIDDataGridViewTextBoxColumn.Name = "patdssPatiIDDataGridViewTextBoxColumn";
            // 
            // patdssDateDataGridViewTextBoxColumn
            // 
            this.patdssDateDataGridViewTextBoxColumn.DataPropertyName = "patdssDate";
            this.patdssDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patdssDateDataGridViewTextBoxColumn.Name = "patdssDateDataGridViewTextBoxColumn";
            // 
            // patdssNameDataGridViewTextBoxColumn
            // 
            this.patdssNameDataGridViewTextBoxColumn.DataPropertyName = "patdssName";
            this.patdssNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.patdssNameDataGridViewTextBoxColumn.Name = "patdssNameDataGridViewTextBoxColumn";
            // 
            // FormTblPatientDiseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblPatientDiseases";
            this.Text = "FormTblPatientDiseases";
            this.Load += new System.EventHandler(this.FormTblPatientDiseases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetPatientDiseases dataSetPatientDiseases;
        private System.Windows.Forms.BindingSource tblPatientDiseasesBindingSource;
        private DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter tblPatientDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssNameDataGridViewTextBoxColumn;
    }
}