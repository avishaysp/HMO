namespace Doctor
{
    partial class FormTblOperations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOperations = new Doctor.DataSetOperations();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblOperationsTableAdapter = new Doctor.DataSetOperationsTableAdapters.tblOperationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationRegNameDataGridViewTextBoxColumn,
            this.operationSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(250, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // operationRegNameDataGridViewTextBoxColumn
            // 
            this.operationRegNameDataGridViewTextBoxColumn.DataPropertyName = "operationRegName";
            this.operationRegNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.operationRegNameDataGridViewTextBoxColumn.Name = "operationRegNameDataGridViewTextBoxColumn";
            // 
            // operationSciNameDataGridViewTextBoxColumn
            // 
            this.operationSciNameDataGridViewTextBoxColumn.DataPropertyName = "operationSciName";
            this.operationSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.operationSciNameDataGridViewTextBoxColumn.Name = "operationSciNameDataGridViewTextBoxColumn";
            // 
            // tblOperationsBindingSource
            // 
            this.tblOperationsBindingSource.DataMember = "tblOperations";
            this.tblOperationsBindingSource.DataSource = this.dataSetOperations;
            // 
            // dataSetOperations
            // 
            this.dataSetOperations.DataSetName = "DataSetOperations";
            this.dataSetOperations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "טבלת ניתוחים";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblOperationsTableAdapter
            // 
            this.tblOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormTblOperations";
            this.Text = "FormTblOperations";
            this.Load += new System.EventHandler(this.FormOperations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private DataSetOperations dataSetOperations;
        private System.Windows.Forms.BindingSource tblOperationsBindingSource;
        private DataSetOperationsTableAdapters.tblOperationsTableAdapter tblOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationSciNameDataGridViewTextBoxColumn;
    }
}