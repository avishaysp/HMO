namespace Doctor
{
    partial class FormTblPatientTreats
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
            this.tblPatientTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientTreats = new Doctor.DataSetPatientTreats();
            this.button1 = new System.Windows.Forms.Button();
            this.tblPatientTreatsTableAdapter = new Doctor.DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter();
            this.pattrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtPatiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(183, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת טיפולים למטופל";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pattrtIDDataGridViewTextBoxColumn,
            this.pattrtPatiIdDataGridViewTextBoxColumn,
            this.pattrtDateDataGridViewTextBoxColumn,
            this.pattrtNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientTreatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(755, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // tblPatientTreatsBindingSource
            // 
            this.tblPatientTreatsBindingSource.DataMember = "tblPatientTreats";
            this.tblPatientTreatsBindingSource.DataSource = this.dataSetPatientTreats;
            // 
            // dataSetPatientTreats
            // 
            this.dataSetPatientTreats.DataSetName = "DataSetPatientTreats";
            this.dataSetPatientTreats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 386);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblPatientTreatsTableAdapter
            // 
            this.tblPatientTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // pattrtIDDataGridViewTextBoxColumn
            // 
            this.pattrtIDDataGridViewTextBoxColumn.DataPropertyName = "pattrtID";
            this.pattrtIDDataGridViewTextBoxColumn.HeaderText = "מספר מזהה";
            this.pattrtIDDataGridViewTextBoxColumn.Name = "pattrtIDDataGridViewTextBoxColumn";
            // 
            // pattrtPatiIdDataGridViewTextBoxColumn
            // 
            this.pattrtPatiIdDataGridViewTextBoxColumn.DataPropertyName = "pattrtPatiId";
            this.pattrtPatiIdDataGridViewTextBoxColumn.HeaderText = "ת\"ז";
            this.pattrtPatiIdDataGridViewTextBoxColumn.Name = "pattrtPatiIdDataGridViewTextBoxColumn";
            // 
            // pattrtDateDataGridViewTextBoxColumn
            // 
            this.pattrtDateDataGridViewTextBoxColumn.DataPropertyName = "pattrtDate";
            this.pattrtDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.pattrtDateDataGridViewTextBoxColumn.Name = "pattrtDateDataGridViewTextBoxColumn";
            // 
            // pattrtNameDataGridViewTextBoxColumn
            // 
            this.pattrtNameDataGridViewTextBoxColumn.DataPropertyName = "pattrtName";
            this.pattrtNameDataGridViewTextBoxColumn.HeaderText = "שם טיפול";
            this.pattrtNameDataGridViewTextBoxColumn.Name = "pattrtNameDataGridViewTextBoxColumn";
            // 
            // FormTblPatientTreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTblPatientTreats";
            this.Text = "FormTblPatientTreats";
            this.Load += new System.EventHandler(this.FormTblPatientTreats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetPatientTreats dataSetPatientTreats;
        private System.Windows.Forms.BindingSource tblPatientTreatsBindingSource;
        private DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter tblPatientTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtPatiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtNameDataGridViewTextBoxColumn;
    }
}