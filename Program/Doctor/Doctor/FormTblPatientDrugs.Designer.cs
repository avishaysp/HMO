namespace Doctor
{
    partial class FormTblPatientDrugs
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblPatientDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDrugs = new Doctor.DataSetPatientDrugs();
            this.tblPatientDrugsTableAdapter = new Doctor.DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter();
            this.patdrgIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 368);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(184, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת תרופות למטופל";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patdrgIDDataGridViewTextBoxColumn,
            this.patdrgPatiIDDataGridViewTextBoxColumn,
            this.patdrgDateDataGridViewTextBoxColumn,
            this.patdrgNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(745, 267);
            this.dataGridView1.TabIndex = 2;
            // 
            // tblPatientDrugsBindingSource
            // 
            this.tblPatientDrugsBindingSource.DataMember = "tblPatientDrugs";
            this.tblPatientDrugsBindingSource.DataSource = this.dataSetPatientDrugs;
            // 
            // dataSetPatientDrugs
            // 
            this.dataSetPatientDrugs.DataSetName = "DataSetPatientDrugs";
            this.dataSetPatientDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPatientDrugsTableAdapter
            // 
            this.tblPatientDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // patdrgIDDataGridViewTextBoxColumn
            // 
            this.patdrgIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgID";
            this.patdrgIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patdrgIDDataGridViewTextBoxColumn.Name = "patdrgIDDataGridViewTextBoxColumn";
            // 
            // patdrgPatiIDDataGridViewTextBoxColumn
            // 
            this.patdrgPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgPatiID";
            this.patdrgPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patdrgPatiIDDataGridViewTextBoxColumn.Name = "patdrgPatiIDDataGridViewTextBoxColumn";
            // 
            // patdrgDateDataGridViewTextBoxColumn
            // 
            this.patdrgDateDataGridViewTextBoxColumn.DataPropertyName = "patdrgDate";
            this.patdrgDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patdrgDateDataGridViewTextBoxColumn.Name = "patdrgDateDataGridViewTextBoxColumn";
            // 
            // patdrgNameDataGridViewTextBoxColumn
            // 
            this.patdrgNameDataGridViewTextBoxColumn.DataPropertyName = "patdrgName";
            this.patdrgNameDataGridViewTextBoxColumn.HeaderText = "שם תרופה";
            this.patdrgNameDataGridViewTextBoxColumn.Name = "patdrgNameDataGridViewTextBoxColumn";
            // 
            // FormTblPatientDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 411);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblPatientDrugs";
            this.Text = "FormTblPatientDrugs";
            this.Load += new System.EventHandler(this.FormTlPatientDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPatientDrugs dataSetPatientDrugs;
        private System.Windows.Forms.BindingSource tblPatientDrugsBindingSource;
        private DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter tblPatientDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgNameDataGridViewTextBoxColumn;
    }
}