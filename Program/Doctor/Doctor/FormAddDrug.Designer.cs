namespace Doctor
{
    partial class FormAddDrug
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
            this.drugRegName = new System.Windows.Forms.TextBox();
            this.drugSciName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drugRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDrugs = new Doctor.DataSetDrugs();
            this.tblDrugsTableAdapter = new Doctor.DataSetDrugsTableAdapters.tblDrugsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת תרופה";
            // 
            // drugRegName
            // 
            this.drugRegName.Location = new System.Drawing.Point(68, 55);
            this.drugRegName.Name = "drugRegName";
            this.drugRegName.Size = new System.Drawing.Size(100, 20);
            this.drugRegName.TabIndex = 1;
            // 
            // drugSciName
            // 
            this.drugSciName.Location = new System.Drawing.Point(68, 82);
            this.drugSciName.Name = "drugSciName";
            this.drugSciName.Size = new System.Drawing.Size(100, 20);
            this.drugSciName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם תרופה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "שם מדעי";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(102, 378);
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
            this.drugRegNameDataGridViewTextBoxColumn,
            this.drugSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(260, 264);
            this.dataGridView1.TabIndex = 6;
            // 
            // drugRegNameDataGridViewTextBoxColumn
            // 
            this.drugRegNameDataGridViewTextBoxColumn.DataPropertyName = "drugRegName";
            this.drugRegNameDataGridViewTextBoxColumn.HeaderText = "שם תרופה";
            this.drugRegNameDataGridViewTextBoxColumn.Name = "drugRegNameDataGridViewTextBoxColumn";
            this.drugRegNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // drugSciNameDataGridViewTextBoxColumn
            // 
            this.drugSciNameDataGridViewTextBoxColumn.DataPropertyName = "drugSciName";
            this.drugSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.drugSciNameDataGridViewTextBoxColumn.Name = "drugSciNameDataGridViewTextBoxColumn";
            this.drugSciNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblDrugsBindingSource
            // 
            this.tblDrugsBindingSource.DataMember = "tblDrugs";
            this.tblDrugsBindingSource.DataSource = this.dataSetDrugs;
            // 
            // dataSetDrugs
            // 
            this.dataSetDrugs.DataSetName = "DataSetDrugs";
            this.dataSetDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDrugsTableAdapter
            // 
            this.tblDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drugSciName);
            this.Controls.Add(this.drugRegName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddDrug";
            this.Text = "FormAddDrug";
            this.Load += new System.EventHandler(this.FormAddDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox drugRegName;
        private System.Windows.Forms.TextBox drugSciName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetDrugs dataSetDrugs;
        private System.Windows.Forms.BindingSource tblDrugsBindingSource;
        private DataSetDrugsTableAdapters.tblDrugsTableAdapter tblDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugSciNameDataGridViewTextBoxColumn;
    }
}