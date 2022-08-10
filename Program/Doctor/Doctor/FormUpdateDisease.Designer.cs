namespace Doctor
{
    partial class FormUpdateDisease
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diseaseRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDiseases = new Doctor.DataSetDiseases();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.diseaseSciName = new System.Windows.Forms.TextBox();
            this.diseaseRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblDiseasesTableAdapter = new Doctor.DataSetDiseasesTableAdapters.tblDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(101, 353);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseRegNameDataGridViewTextBoxColumn,
            this.diseaseSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 177);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // diseaseRegNameDataGridViewTextBoxColumn
            // 
            this.diseaseRegNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseRegName";
            this.diseaseRegNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.diseaseRegNameDataGridViewTextBoxColumn.Name = "diseaseRegNameDataGridViewTextBoxColumn";
            // 
            // diseaseSciNameDataGridViewTextBoxColumn
            // 
            this.diseaseSciNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseSciName";
            this.diseaseSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.diseaseSciNameDataGridViewTextBoxColumn.Name = "diseaseSciNameDataGridViewTextBoxColumn";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "שם מדעי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "שם מחלה";
            // 
            // diseaseSciName
            // 
            this.diseaseSciName.Location = new System.Drawing.Point(64, 86);
            this.diseaseSciName.Name = "diseaseSciName";
            this.diseaseSciName.Size = new System.Drawing.Size(100, 20);
            this.diseaseSciName.TabIndex = 9;
            // 
            // diseaseRegName
            // 
            this.diseaseRegName.Enabled = false;
            this.diseaseRegName.Location = new System.Drawing.Point(64, 60);
            this.diseaseRegName.Name = "diseaseRegName";
            this.diseaseRegName.Size = new System.Drawing.Size(100, 20);
            this.diseaseRegName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(58, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "עדכון מחלה";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(64, 112);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 100;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(145, 141);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 99;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(64, 141);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 98;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(145, 112);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 97;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblDiseasesTableAdapter
            // 
            this.tblDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdateDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 387);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diseaseSciName);
            this.Controls.Add(this.diseaseRegName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateDisease";
            this.Text = "FormUpdateDisease";
            this.Load += new System.EventHandler(this.FormUpdateDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox diseaseSciName;
        private System.Windows.Forms.TextBox diseaseRegName;
        private System.Windows.Forms.Label label1;
        private DataSetDiseases dataSetDiseases;
        private System.Windows.Forms.BindingSource tblDiseasesBindingSource;
        private DataSetDiseasesTableAdapters.tblDiseasesTableAdapter tblDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseSciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}