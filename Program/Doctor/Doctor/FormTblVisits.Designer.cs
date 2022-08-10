namespace Doctor
{
    partial class FormTblVisits
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
            this.visitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitpatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVisits = new Doctor.DataSetVisits();
            this.button1 = new System.Windows.Forms.Button();
            this.tblVisitsTableAdapter = new Doctor.DataSetVisitsTableAdapters.tblVisitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(197, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת ביקורים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIDDataGridViewTextBoxColumn,
            this.visitpatiIDDataGridViewTextBoxColumn,
            this.visitDateDataGridViewTextBoxColumn,
            this.visitHourDataGridViewTextBoxColumn,
            this.visitNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVisitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(544, 259);
            this.dataGridView1.TabIndex = 1;
            // 
            // visitIDDataGridViewTextBoxColumn
            // 
            this.visitIDDataGridViewTextBoxColumn.DataPropertyName = "visitID";
            this.visitIDDataGridViewTextBoxColumn.HeaderText = "מספר ביקור";
            this.visitIDDataGridViewTextBoxColumn.Name = "visitIDDataGridViewTextBoxColumn";
            // 
            // visitpatiIDDataGridViewTextBoxColumn
            // 
            this.visitpatiIDDataGridViewTextBoxColumn.DataPropertyName = "visitpatiID";
            this.visitpatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.visitpatiIDDataGridViewTextBoxColumn.Name = "visitpatiIDDataGridViewTextBoxColumn";
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "visitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "visitHour";
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            // 
            // visitNotesDataGridViewTextBoxColumn
            // 
            this.visitNotesDataGridViewTextBoxColumn.DataPropertyName = "visitNotes";
            this.visitNotesDataGridViewTextBoxColumn.HeaderText = "הערות";
            this.visitNotesDataGridViewTextBoxColumn.Name = "visitNotesDataGridViewTextBoxColumn";
            // 
            // tblVisitsBindingSource
            // 
            this.tblVisitsBindingSource.DataMember = "tblVisits";
            this.tblVisitsBindingSource.DataSource = this.dataSetVisits;
            // 
            // dataSetVisits
            // 
            this.dataSetVisits.DataSetName = "DataSetVisits";
            this.dataSetVisits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblVisitsTableAdapter
            // 
            this.tblVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblVisits";
            this.Text = "FormTblVisits";
            this.Load += new System.EventHandler(this.FormTblVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetVisits dataSetVisits;
        private System.Windows.Forms.BindingSource tblVisitsBindingSource;
        private DataSetVisitsTableAdapters.tblVisitsTableAdapter tblVisitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitpatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitNotesDataGridViewTextBoxColumn;
    }
}