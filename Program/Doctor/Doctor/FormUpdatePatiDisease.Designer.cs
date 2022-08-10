namespace Doctor
{
    partial class FormUpdatePatiDisease
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
            this.patdssName = new System.Windows.Forms.ComboBox();
            this.patdssPatiID = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patdssIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patdssNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientDiseases = new Doctor.DataSetPatientDiseases();
            this.patdssDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patdssID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblPatientDiseasesTableAdapter = new Doctor.DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).BeginInit();
            this.SuspendLayout();
            // 
            // patdssName
            // 
            this.patdssName.FormattingEnabled = true;
            this.patdssName.Location = new System.Drawing.Point(54, 87);
            this.patdssName.Name = "patdssName";
            this.patdssName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patdssName.Size = new System.Drawing.Size(101, 21);
            this.patdssName.TabIndex = 38;
            // 
            // patdssPatiID
            // 
            this.patdssPatiID.FormattingEnabled = true;
            this.patdssPatiID.Location = new System.Drawing.Point(225, 87);
            this.patdssPatiID.Name = "patdssPatiID";
            this.patdssPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patdssPatiID.Size = new System.Drawing.Size(100, 21);
            this.patdssPatiID.TabIndex = 37;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(181, 460);
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
            this.patdssIDDataGridViewTextBoxColumn,
            this.patdssPatiIDDataGridViewTextBoxColumn,
            this.patdssDateDataGridViewTextBoxColumn,
            this.patdssNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(397, 296);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patdssIDDataGridViewTextBoxColumn
            // 
            this.patdssIDDataGridViewTextBoxColumn.DataPropertyName = "patdssID";
            this.patdssIDDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.patdssIDDataGridViewTextBoxColumn.Name = "patdssIDDataGridViewTextBoxColumn";
            // 
            // patdssPatiIDDataGridViewTextBoxColumn
            // 
            this.patdssPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patdssPatiID";
            this.patdssPatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.patdssPatiIDDataGridViewTextBoxColumn.Name = "patdssPatiIDDataGridViewTextBoxColumn";
            // 
            // patdssDateDataGridViewTextBoxColumn
            // 
            this.patdssDateDataGridViewTextBoxColumn.DataPropertyName = "patdssDate";
            this.patdssDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patdssDateDataGridViewTextBoxColumn.Name = "patdssDateDataGridViewTextBoxColumn";
            // 
            // patdssNameDataGridViewTextBoxColumn
            // 
            this.patdssNameDataGridViewTextBoxColumn.DataPropertyName = "patdssName";
            this.patdssNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.patdssNameDataGridViewTextBoxColumn.Name = "patdssNameDataGridViewTextBoxColumn";
            // 
            // tblPatientDiseasesBindingSource
            // 
            this.tblPatientDiseasesBindingSource.DataMember = "tblPatientDiseases";
            this.tblPatientDiseasesBindingSource.DataSource = this.dataSetPatientDiseases;
            // 
            // dataSetPatientDiseases
            // 
            this.dataSetPatientDiseases.DataSetName = "DataSetPatientDiseases";
            this.dataSetPatientDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patdssDate
            // 
            this.patdssDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patdssDate.Location = new System.Drawing.Point(54, 57);
            this.patdssDate.Name = "patdssDate";
            this.patdssDate.Size = new System.Drawing.Size(101, 20);
            this.patdssDate.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "מחלה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "ת\"ז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "עדכון מחלה למטופל";
            // 
            // patdssID
            // 
            this.patdssID.Enabled = false;
            this.patdssID.Location = new System.Drawing.Point(225, 61);
            this.patdssID.Name = "patdssID";
            this.patdssID.Size = new System.Drawing.Size(100, 20);
            this.patdssID.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "מספר סידורי";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(63, 129);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 112;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(225, 129);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 111;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(144, 129);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 110;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(306, 129);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 109;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblPatientDiseasesTableAdapter
            // 
            this.tblPatientDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdatePatiDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 495);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patdssID);
            this.Controls.Add(this.patdssName);
            this.Controls.Add(this.patdssPatiID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patdssDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePatiDisease";
            this.Text = "FormUpdatePatiDisease";
            this.Load += new System.EventHandler(this.FormUpdatePatiDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientDiseasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientDiseases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox patdssName;
        private System.Windows.Forms.ComboBox patdssPatiID;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patdssDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patdssID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private DataSetPatientDiseases dataSetPatientDiseases;
        private System.Windows.Forms.BindingSource tblPatientDiseasesBindingSource;
        private DataSetPatientDiseasesTableAdapters.tblPatientDiseasesTableAdapter tblPatientDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patdssNameDataGridViewTextBoxColumn;
    }
}