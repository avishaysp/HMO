namespace Doctor
{
    partial class FormUpdatePatiDrug
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
            this.patdrgName = new System.Windows.Forms.ComboBox();
            this.patdrgPatiID = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patdrgIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdrgNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDrugs = new Doctor.DataSetPatientDrugs();
            this.patdrgDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patdrgID = new System.Windows.Forms.TextBox();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblPatientDrugsTableAdapter = new Doctor.DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // patdrgName
            // 
            this.patdrgName.FormattingEnabled = true;
            this.patdrgName.Location = new System.Drawing.Point(54, 82);
            this.patdrgName.Name = "patdrgName";
            this.patdrgName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patdrgName.Size = new System.Drawing.Size(101, 21);
            this.patdrgName.TabIndex = 36;
            // 
            // patdrgPatiID
            // 
            this.patdrgPatiID.FormattingEnabled = true;
            this.patdrgPatiID.Location = new System.Drawing.Point(235, 82);
            this.patdrgPatiID.Name = "patdrgPatiID";
            this.patdrgPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patdrgPatiID.Size = new System.Drawing.Size(100, 21);
            this.patdrgPatiID.TabIndex = 37;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(165, 452);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 35;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patdrgIDDataGridViewTextBoxColumn,
            this.patdrgPatiIDDataGridViewTextBoxColumn,
            this.patdrgDateDataGridViewTextBoxColumn,
            this.patdrgNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(396, 308);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patdrgIDDataGridViewTextBoxColumn
            // 
            this.patdrgIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgID";
            this.patdrgIDDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.patdrgIDDataGridViewTextBoxColumn.Name = "patdrgIDDataGridViewTextBoxColumn";
            // 
            // patdrgPatiIDDataGridViewTextBoxColumn
            // 
            this.patdrgPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdrgPatiID";
            this.patdrgPatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
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
            // patdrgDate
            // 
            this.patdrgDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patdrgDate.Location = new System.Drawing.Point(54, 56);
            this.patdrgDate.Name = "patdrgDate";
            this.patdrgDate.Size = new System.Drawing.Size(101, 20);
            this.patdrgDate.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "תרופה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(77, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "עדכון תרופה למטופל";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "מספר סידורי";
            // 
            // patdrgID
            // 
            this.patdrgID.Enabled = false;
            this.patdrgID.Location = new System.Drawing.Point(235, 56);
            this.patdrgID.Name = "patdrgID";
            this.patdrgID.Size = new System.Drawing.Size(100, 20);
            this.patdrgID.TabIndex = 39;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(46, 109);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 108;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(208, 109);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 107;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(127, 109);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 106;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(289, 109);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 105;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblPatientDrugsTableAdapter
            // 
            this.tblPatientDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdatePatiDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 481);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.patdrgID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patdrgName);
            this.Controls.Add(this.patdrgPatiID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patdrgDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePatiDrug";
            this.Text = "FormUpdatePatiDrug";
            this.Load += new System.EventHandler(this.FormUpdatePatiDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patdrgName;
        private System.Windows.Forms.ComboBox patdrgPatiID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patdrgDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox patdrgID;
        private DataSetPatientDrugs dataSetPatientDrugs;
        private System.Windows.Forms.BindingSource tblPatientDrugsBindingSource;
        private DataSetPatientDrugsTableAdapters.tblPatientDrugsTableAdapter tblPatientDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdrgNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}