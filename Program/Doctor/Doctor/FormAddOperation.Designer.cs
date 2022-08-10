namespace Doctor
{
    partial class FormAddOperation
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
            this.label2 = new System.Windows.Forms.Label();
            this.operationRegName = new System.Windows.Forms.TextBox();
            this.operationSciName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetOperations = new Doctor.DataSetOperations();
            this.tblOperationsTableAdapter = new Doctor.DataSetOperationsTableAdapters.tblOperationsTableAdapter();
            this.buttonAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת ניתוח";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם ניתוח";
            // 
            // operationRegName
            // 
            this.operationRegName.Location = new System.Drawing.Point(52, 57);
            this.operationRegName.Name = "operationRegName";
            this.operationRegName.Size = new System.Drawing.Size(100, 20);
            this.operationRegName.TabIndex = 2;
            // 
            // operationSciName
            // 
            this.operationSciName.Location = new System.Drawing.Point(52, 84);
            this.operationSciName.Name = "operationSciName";
            this.operationSciName.Size = new System.Drawing.Size(100, 20);
            this.operationSciName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "שם מדעי";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.operationRegNameDataGridViewTextBoxColumn,
            this.operationSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(261, 260);
            this.dataGridView1.TabIndex = 5;
            // 
            // operationRegNameDataGridViewTextBoxColumn
            // 
            this.operationRegNameDataGridViewTextBoxColumn.DataPropertyName = "operationRegName";
            this.operationRegNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.operationRegNameDataGridViewTextBoxColumn.Name = "operationRegNameDataGridViewTextBoxColumn";
            this.operationRegNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operationSciNameDataGridViewTextBoxColumn
            // 
            this.operationSciNameDataGridViewTextBoxColumn.DataPropertyName = "operationSciName";
            this.operationSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.operationSciNameDataGridViewTextBoxColumn.Name = "operationSciNameDataGridViewTextBoxColumn";
            this.operationSciNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // tblOperationsTableAdapter
            // 
            this.tblOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(106, 376);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormAddOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 411);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operationSciName);
            this.Controls.Add(this.operationRegName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOperation";
            this.Text = "FormAddOperation";
            this.Load += new System.EventHandler(this.FormAddOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox operationRegName;
        private System.Windows.Forms.TextBox operationSciName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetOperations dataSetOperations;
        private System.Windows.Forms.BindingSource tblOperationsBindingSource;
        private DataSetOperationsTableAdapters.tblOperationsTableAdapter tblOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationSciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonAdd;
    }
}