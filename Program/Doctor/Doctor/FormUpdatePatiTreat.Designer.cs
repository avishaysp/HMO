namespace Doctor
{
    partial class FormUpdatePatiTreat
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
            this.pattrtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtPatiIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pattrtNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientTreats = new Doctor.DataSetPatientTreats();
            this.pattrtDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.pattrtName = new System.Windows.Forms.ComboBox();
            this.pattrtPatiId = new System.Windows.Forms.ComboBox();
            this.pattrtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tblPatientTreatsTableAdapter = new Doctor.DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(180, 456);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 24);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "עדכון";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(10, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(426, 304);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pattrtIDDataGridViewTextBoxColumn
            // 
            this.pattrtIDDataGridViewTextBoxColumn.DataPropertyName = "pattrtID";
            this.pattrtIDDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.pattrtIDDataGridViewTextBoxColumn.Name = "pattrtIDDataGridViewTextBoxColumn";
            // 
            // pattrtPatiIdDataGridViewTextBoxColumn
            // 
            this.pattrtPatiIdDataGridViewTextBoxColumn.DataPropertyName = "pattrtPatiId";
            this.pattrtPatiIdDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
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
            // pattrtDate
            // 
            this.pattrtDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.pattrtDate.Location = new System.Drawing.Point(71, 59);
            this.pattrtDate.Name = "pattrtDate";
            this.pattrtDate.Size = new System.Drawing.Size(101, 20);
            this.pattrtDate.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "טיפול";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(83, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "עדכון טיפול למטופל";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(61, 117);
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
            this.buttonPrev.Location = new System.Drawing.Point(223, 117);
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
            this.buttonNext.Location = new System.Drawing.Point(142, 117);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 106;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(304, 117);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 105;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // pattrtName
            // 
            this.pattrtName.FormattingEnabled = true;
            this.pattrtName.Location = new System.Drawing.Point(71, 85);
            this.pattrtName.Name = "pattrtName";
            this.pattrtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pattrtName.Size = new System.Drawing.Size(101, 21);
            this.pattrtName.TabIndex = 38;
            // 
            // pattrtPatiId
            // 
            this.pattrtPatiId.FormattingEnabled = true;
            this.pattrtPatiId.Location = new System.Drawing.Point(248, 87);
            this.pattrtPatiId.Name = "pattrtPatiId";
            this.pattrtPatiId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pattrtPatiId.Size = new System.Drawing.Size(100, 21);
            this.pattrtPatiId.TabIndex = 37;
            // 
            // pattrtID
            // 
            this.pattrtID.Enabled = false;
            this.pattrtID.Location = new System.Drawing.Point(248, 61);
            this.pattrtID.Name = "pattrtID";
            this.pattrtID.Size = new System.Drawing.Size(100, 20);
            this.pattrtID.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "מספר סידורי";
            // 
            // tblPatientTreatsTableAdapter
            // 
            this.tblPatientTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdatePatiTreat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 492);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pattrtID);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.pattrtName);
            this.Controls.Add(this.pattrtPatiId);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pattrtDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePatiTreat";
            this.Text = "FormUpdatePatiTreat";
            this.Load += new System.EventHandler(this.FormUpdatePatiTreat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker pattrtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private DataSetPatientTreats dataSetPatientTreats;
        private System.Windows.Forms.BindingSource tblPatientTreatsBindingSource;
        private DataSetPatientTreatsTableAdapters.tblPatientTreatsTableAdapter tblPatientTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtPatiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pattrtNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox pattrtName;
        private System.Windows.Forms.ComboBox pattrtPatiId;
        private System.Windows.Forms.TextBox pattrtID;
        private System.Windows.Forms.Label label2;
    }
}