namespace Doctor
{
    partial class FormUpdatePatiVaccine
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
            this.patvacName = new System.Windows.Forms.ComboBox();
            this.patvacPatientID = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patvacIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacPatientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patvacNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientVaccines = new Doctor.DataSetPatientVaccines();
            this.patvacDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patvacID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataSetPatientVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPatientVaccinesTableAdapter = new Doctor.DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccinesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // patvacName
            // 
            this.patvacName.FormattingEnabled = true;
            this.patvacName.Location = new System.Drawing.Point(44, 70);
            this.patvacName.Name = "patvacName";
            this.patvacName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patvacName.Size = new System.Drawing.Size(100, 21);
            this.patvacName.TabIndex = 38;
            // 
            // patvacPatientID
            // 
            this.patvacPatientID.FormattingEnabled = true;
            this.patvacPatientID.Location = new System.Drawing.Point(208, 70);
            this.patvacPatientID.Name = "patvacPatientID";
            this.patvacPatientID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patvacPatientID.Size = new System.Drawing.Size(100, 21);
            this.patvacPatientID.TabIndex = 37;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(169, 482);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 36;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patvacIDDataGridViewTextBoxColumn,
            this.patvacPatientIDDataGridViewTextBoxColumn,
            this.patvacDateDataGridViewTextBoxColumn,
            this.patvacNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(393, 350);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patvacIDDataGridViewTextBoxColumn
            // 
            this.patvacIDDataGridViewTextBoxColumn.DataPropertyName = "patvacID";
            this.patvacIDDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.patvacIDDataGridViewTextBoxColumn.Name = "patvacIDDataGridViewTextBoxColumn";
            // 
            // patvacPatientIDDataGridViewTextBoxColumn
            // 
            this.patvacPatientIDDataGridViewTextBoxColumn.DataPropertyName = "patvacPatientID";
            this.patvacPatientIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.patvacPatientIDDataGridViewTextBoxColumn.Name = "patvacPatientIDDataGridViewTextBoxColumn";
            // 
            // patvacDateDataGridViewTextBoxColumn
            // 
            this.patvacDateDataGridViewTextBoxColumn.DataPropertyName = "patvacDate";
            this.patvacDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patvacDateDataGridViewTextBoxColumn.Name = "patvacDateDataGridViewTextBoxColumn";
            // 
            // patvacNameDataGridViewTextBoxColumn
            // 
            this.patvacNameDataGridViewTextBoxColumn.DataPropertyName = "patvacName";
            this.patvacNameDataGridViewTextBoxColumn.HeaderText = "שם חיסון";
            this.patvacNameDataGridViewTextBoxColumn.Name = "patvacNameDataGridViewTextBoxColumn";
            // 
            // tblPatientVaccinesBindingSource
            // 
            this.tblPatientVaccinesBindingSource.DataMember = "tblPatientVaccines";
            this.tblPatientVaccinesBindingSource.DataSource = this.dataSetPatientVaccines;
            // 
            // dataSetPatientVaccines
            // 
            this.dataSetPatientVaccines.DataSetName = "DataSetPatientVaccines";
            this.dataSetPatientVaccines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patvacDate
            // 
            this.patvacDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patvacDate.Location = new System.Drawing.Point(43, 44);
            this.patvacDate.Name = "patvacDate";
            this.patvacDate.Size = new System.Drawing.Size(101, 20);
            this.patvacDate.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "חיסון";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ת\"ז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "עדכון חיסון למטופל";
            // 
            // patvacID
            // 
            this.patvacID.Enabled = false;
            this.patvacID.Location = new System.Drawing.Point(208, 44);
            this.patvacID.Name = "patvacID";
            this.patvacID.Size = new System.Drawing.Size(100, 20);
            this.patvacID.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "מספר סידורי";
            // 
            // dataSetPatientVaccinesBindingSource
            // 
            this.dataSetPatientVaccinesBindingSource.DataSource = this.dataSetPatientVaccines;
            this.dataSetPatientVaccinesBindingSource.Position = 0;
            // 
            // tblPatientVaccinesTableAdapter
            // 
            this.tblPatientVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(46, 97);
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
            this.buttonPrev.Location = new System.Drawing.Point(208, 97);
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
            this.buttonNext.Location = new System.Drawing.Point(127, 97);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 106;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(289, 97);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 105;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // FormUpdatePatiVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 515);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patvacID);
            this.Controls.Add(this.patvacName);
            this.Controls.Add(this.patvacPatientID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patvacDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePatiVaccine";
            this.Text = "FormUpdatePatiVaccine";
            this.Load += new System.EventHandler(this.FormUpdatePatiVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientVaccinesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patvacName;
        private System.Windows.Forms.ComboBox patvacPatientID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patvacDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dataSetPatientVaccinesBindingSource;
        private DataSetPatientVaccines dataSetPatientVaccines;
        private System.Windows.Forms.BindingSource tblPatientVaccinesBindingSource;
        private DataSetPatientVaccinesTableAdapters.tblPatientVaccinesTableAdapter tblPatientVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacPatientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patvacNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox patvacID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}