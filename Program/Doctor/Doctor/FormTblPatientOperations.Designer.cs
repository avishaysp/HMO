namespace Doctor
{
    partial class FormTblPatientOperations
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
            this.tblPatientOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientOperations = new Doctor.DataSetPatientOperations();
            this.tblPatientOperationsTableAdapter = new Doctor.DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter();
            this.patoprIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 377);
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
            this.label1.Location = new System.Drawing.Point(232, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת ניתוחים למטופל";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patoprIDDataGridViewTextBoxColumn,
            this.patoprPatiIDDataGridViewTextBoxColumn,
            this.patoprDateDataGridViewTextBoxColumn,
            this.patoprNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 80);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(783, 289);
            this.dataGridView1.TabIndex = 2;
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
            // tblPatientOperationsTableAdapter
            // 
            this.tblPatientOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // patoprIDDataGridViewTextBoxColumn
            // 
            this.patoprIDDataGridViewTextBoxColumn.DataPropertyName = "patoprID";
            this.patoprIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.patoprIDDataGridViewTextBoxColumn.Name = "patoprIDDataGridViewTextBoxColumn";
            // 
            // patoprPatiIDDataGridViewTextBoxColumn
            // 
            this.patoprPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patoprPatiID";
            this.patoprPatiIDDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.patoprPatiIDDataGridViewTextBoxColumn.Name = "patoprPatiIDDataGridViewTextBoxColumn";
            // 
            // patoprDateDataGridViewTextBoxColumn
            // 
            this.patoprDateDataGridViewTextBoxColumn.DataPropertyName = "patoprDate";
            this.patoprDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patoprDateDataGridViewTextBoxColumn.Name = "patoprDateDataGridViewTextBoxColumn";
            // 
            // patoprNameDataGridViewTextBoxColumn
            // 
            this.patoprNameDataGridViewTextBoxColumn.DataPropertyName = "patoprName";
            this.patoprNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.patoprNameDataGridViewTextBoxColumn.Name = "patoprNameDataGridViewTextBoxColumn";
            // 
            // FormTblPatientOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblPatientOperations";
            this.Text = "FormTblPatientOperations";
            this.Load += new System.EventHandler(this.FormTblPatientOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetPatientOperations dataSetPatientOperations;
        private System.Windows.Forms.BindingSource tblPatientOperationsBindingSource;
        private DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter tblPatientOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprNameDataGridViewTextBoxColumn;
    }
}