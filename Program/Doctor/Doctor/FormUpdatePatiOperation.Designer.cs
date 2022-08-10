namespace Doctor
{
    partial class FormUpdatePatiOperation
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
            this.patoprIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprPatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patoprNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPatientOperationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetPatientOperations = new Doctor.DataSetPatientOperations();
            this.patoprDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblPatientOperationsTableAdapter = new Doctor.DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter();
            this.patoprPatiID = new System.Windows.Forms.ComboBox();
            this.patoprName = new System.Windows.Forms.ComboBox();
            this.patoprID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(161, 414);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patoprIDDataGridViewTextBoxColumn,
            this.patoprPatiIDDataGridViewTextBoxColumn,
            this.patoprDateDataGridViewTextBoxColumn,
            this.patoprNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPatientOperationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(390, 256);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patoprIDDataGridViewTextBoxColumn
            // 
            this.patoprIDDataGridViewTextBoxColumn.DataPropertyName = "patoprID";
            this.patoprIDDataGridViewTextBoxColumn.HeaderText = "מספר סידורי";
            this.patoprIDDataGridViewTextBoxColumn.Name = "patoprIDDataGridViewTextBoxColumn";
            // 
            // patoprPatiIDDataGridViewTextBoxColumn
            // 
            this.patoprPatiIDDataGridViewTextBoxColumn.DataPropertyName = "patoprPatiID";
            this.patoprPatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.patoprPatiIDDataGridViewTextBoxColumn.Name = "patoprPatiIDDataGridViewTextBoxColumn";
            // 
            // patoprDateDataGridViewTextBoxColumn
            // 
            this.patoprDateDataGridViewTextBoxColumn.DataPropertyName = "patoprDate";
            this.patoprDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.patoprDateDataGridViewTextBoxColumn.Name = "patoprDateDataGridViewTextBoxColumn";
            // 
            // patoprNameDataGridViewTextBoxColumn
            // 
            this.patoprNameDataGridViewTextBoxColumn.DataPropertyName = "patoprName";
            this.patoprNameDataGridViewTextBoxColumn.HeaderText = "שם ניתוח";
            this.patoprNameDataGridViewTextBoxColumn.Name = "patoprNameDataGridViewTextBoxColumn";
            // 
            // tblPatientOperationsBindingSource
            // 
            this.tblPatientOperationsBindingSource.DataMember = "tblPatientOperations";
            this.tblPatientOperationsBindingSource.DataSource = this.dataSetPatientOperations;
            // 
            // dataSetPatientOperations
            // 
            this.dataSetPatientOperations.DataSetName = "DataSetPatientOperations";
            this.dataSetPatientOperations.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patoprDate
            // 
            this.patoprDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.patoprDate.Location = new System.Drawing.Point(65, 57);
            this.patoprDate.Name = "patoprDate";
            this.patoprDate.Size = new System.Drawing.Size(101, 20);
            this.patoprDate.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "ניתוח";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "תז מטופל";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "עדכון ניתוח למטופל";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(52, 123);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 104;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(214, 123);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 103;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(133, 123);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 102;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(295, 123);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 101;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblPatientOperationsTableAdapter
            // 
            this.tblPatientOperationsTableAdapter.ClearBeforeFill = true;
            // 
            // patoprPatiID
            // 
            this.patoprPatiID.FormattingEnabled = true;
            this.patoprPatiID.Location = new System.Drawing.Point(220, 83);
            this.patoprPatiID.Name = "patoprPatiID";
            this.patoprPatiID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patoprPatiID.Size = new System.Drawing.Size(101, 21);
            this.patoprPatiID.TabIndex = 105;
            // 
            // patoprName
            // 
            this.patoprName.FormattingEnabled = true;
            this.patoprName.Location = new System.Drawing.Point(65, 83);
            this.patoprName.Name = "patoprName";
            this.patoprName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.patoprName.Size = new System.Drawing.Size(101, 21);
            this.patoprName.TabIndex = 105;
            // 
            // patoprID
            // 
            this.patoprID.Enabled = false;
            this.patoprID.Location = new System.Drawing.Point(220, 56);
            this.patoprID.Name = "patoprID";
            this.patoprID.Size = new System.Drawing.Size(101, 20);
            this.patoprID.TabIndex = 106;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "מספר סידורי";
            // 
            // FormUpdatePatiOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patoprID);
            this.Controls.Add(this.patoprName);
            this.Controls.Add(this.patoprPatiID);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patoprDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdatePatiOperation";
            this.Text = "FormUpdatePtientOperation";
            this.Load += new System.EventHandler(this.FormUpdatePtiOperation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPatientOperationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetPatientOperations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker patoprDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private DataSetPatientOperations dataSetPatientOperations;
        private System.Windows.Forms.BindingSource tblPatientOperationsBindingSource;
        private DataSetPatientOperationsTableAdapters.tblPatientOperationsTableAdapter tblPatientOperationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprPatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patoprNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox patoprPatiID;
        private System.Windows.Forms.ComboBox patoprName;
        private System.Windows.Forms.TextBox patoprID;
        private System.Windows.Forms.Label label2;
    }
}