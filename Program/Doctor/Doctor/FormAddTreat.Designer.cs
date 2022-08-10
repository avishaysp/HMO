namespace Doctor
{
    partial class FormAddTreat
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
            this.treatRegName = new System.Windows.Forms.TextBox();
            this.treatSciName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.treatRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTreats = new Doctor.DataSetTreats();
            this.tblTreatsTableAdapter = new Doctor.DataSetTreatsTableAdapters.tblTreatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת טיפול";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "שם טיפול";
            // 
            // treatRegName
            // 
            this.treatRegName.Location = new System.Drawing.Point(88, 69);
            this.treatRegName.Name = "treatRegName";
            this.treatRegName.Size = new System.Drawing.Size(100, 20);
            this.treatRegName.TabIndex = 2;
            // 
            // treatSciName
            // 
            this.treatSciName.Location = new System.Drawing.Point(88, 96);
            this.treatSciName.Name = "treatSciName";
            this.treatSciName.Size = new System.Drawing.Size(100, 20);
            this.treatSciName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "שם מדעי";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(100, 428);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatRegNameDataGridViewTextBoxColumn,
            this.treatSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTreatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(260, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // treatRegNameDataGridViewTextBoxColumn
            // 
            this.treatRegNameDataGridViewTextBoxColumn.DataPropertyName = "treatRegName";
            this.treatRegNameDataGridViewTextBoxColumn.HeaderText = "שם טיפול";
            this.treatRegNameDataGridViewTextBoxColumn.Name = "treatRegNameDataGridViewTextBoxColumn";
            this.treatRegNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treatSciNameDataGridViewTextBoxColumn
            // 
            this.treatSciNameDataGridViewTextBoxColumn.DataPropertyName = "treatSciName";
            this.treatSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.treatSciNameDataGridViewTextBoxColumn.Name = "treatSciNameDataGridViewTextBoxColumn";
            this.treatSciNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblTreatsBindingSource
            // 
            this.tblTreatsBindingSource.DataMember = "tblTreats";
            this.tblTreatsBindingSource.DataSource = this.dataSetTreats;
            // 
            // dataSetTreats
            // 
            this.dataSetTreats.DataSetName = "DataSetTreats";
            this.dataSetTreats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblTreatsTableAdapter
            // 
            this.tblTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddTreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treatSciName);
            this.Controls.Add(this.treatRegName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddTreat";
            this.Text = "FormAddTreat";
            this.Load += new System.EventHandler(this.FormAddTreat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox treatRegName;
        private System.Windows.Forms.TextBox treatSciName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetTreats dataSetTreats;
        private System.Windows.Forms.BindingSource tblTreatsBindingSource;
        private DataSetTreatsTableAdapters.tblTreatsTableAdapter tblTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatSciNameDataGridViewTextBoxColumn;
    }
}