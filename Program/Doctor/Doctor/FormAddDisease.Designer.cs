namespace Doctor
{
    partial class FormAddDisease
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
            this.diseaseRegName = new System.Windows.Forms.TextBox();
            this.diseaseSciName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diseaseRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDiseases = new Doctor.DataSetDiseases();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tblDiseasesTableAdapter = new Doctor.DataSetDiseasesTableAdapters.tblDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(58, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת מחלה";
            // 
            // diseaseRegName
            // 
            this.diseaseRegName.Location = new System.Drawing.Point(64, 59);
            this.diseaseRegName.Name = "diseaseRegName";
            this.diseaseRegName.Size = new System.Drawing.Size(100, 20);
            this.diseaseRegName.TabIndex = 1;
            // 
            // diseaseSciName
            // 
            this.diseaseSciName.Location = new System.Drawing.Point(64, 85);
            this.diseaseSciName.Name = "diseaseSciName";
            this.diseaseSciName.Size = new System.Drawing.Size(100, 20);
            this.diseaseSciName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם מחלה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 88);
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
            this.diseaseRegNameDataGridViewTextBoxColumn,
            this.diseaseSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(260, 266);
            this.dataGridView1.TabIndex = 5;
            // 
            // diseaseRegNameDataGridViewTextBoxColumn
            // 
            this.diseaseRegNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseRegName";
            this.diseaseRegNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.diseaseRegNameDataGridViewTextBoxColumn.Name = "diseaseRegNameDataGridViewTextBoxColumn";
            this.diseaseRegNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diseaseSciNameDataGridViewTextBoxColumn
            // 
            this.diseaseSciNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseSciName";
            this.diseaseSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.diseaseSciNameDataGridViewTextBoxColumn.Name = "diseaseSciNameDataGridViewTextBoxColumn";
            this.diseaseSciNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(98, 383);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tblDiseasesTableAdapter
            // 
            this.tblDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 418);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diseaseSciName);
            this.Controls.Add(this.diseaseRegName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddDisease";
            this.Text = "FormAddDisease";
            this.Load += new System.EventHandler(this.FormaddDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diseaseRegName;
        private System.Windows.Forms.TextBox diseaseSciName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private DataSetDiseases dataSetDiseases;
        private System.Windows.Forms.BindingSource tblDiseasesBindingSource;
        private DataSetDiseasesTableAdapters.tblDiseasesTableAdapter tblDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseSciNameDataGridViewTextBoxColumn;
    }
}