namespace Doctor
{
    partial class FormUpdateVisits
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
            this.visitIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitpatiIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVisitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVisits = new Doctor.DataSetVisits();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.visitNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.visitHour = new System.Windows.Forms.DateTimePicker();
            this.visitDate = new System.Windows.Forms.DateTimePicker();
            this.visitpatiID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.visitID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.tblVisitsTableAdapter = new Doctor.DataSetVisitsTableAdapters.tblVisitsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(289, 394);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 25;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitIDDataGridViewTextBoxColumn,
            this.visitpatiIDDataGridViewTextBoxColumn,
            this.visitDateDataGridViewTextBoxColumn,
            this.visitHourDataGridViewTextBoxColumn,
            this.visitNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVisitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(631, 227);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // visitIDDataGridViewTextBoxColumn
            // 
            this.visitIDDataGridViewTextBoxColumn.DataPropertyName = "visitID";
            this.visitIDDataGridViewTextBoxColumn.HeaderText = "מספר ביקור";
            this.visitIDDataGridViewTextBoxColumn.Name = "visitIDDataGridViewTextBoxColumn";
            // 
            // visitpatiIDDataGridViewTextBoxColumn
            // 
            this.visitpatiIDDataGridViewTextBoxColumn.DataPropertyName = "visitpatiID";
            this.visitpatiIDDataGridViewTextBoxColumn.HeaderText = "תז מטופל";
            this.visitpatiIDDataGridViewTextBoxColumn.Name = "visitpatiIDDataGridViewTextBoxColumn";
            // 
            // visitDateDataGridViewTextBoxColumn
            // 
            this.visitDateDataGridViewTextBoxColumn.DataPropertyName = "visitDate";
            this.visitDateDataGridViewTextBoxColumn.HeaderText = "תאריך";
            this.visitDateDataGridViewTextBoxColumn.Name = "visitDateDataGridViewTextBoxColumn";
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "visitHour";
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "שעה";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            // 
            // visitNotesDataGridViewTextBoxColumn
            // 
            this.visitNotesDataGridViewTextBoxColumn.DataPropertyName = "visitNotes";
            this.visitNotesDataGridViewTextBoxColumn.HeaderText = "הערות";
            this.visitNotesDataGridViewTextBoxColumn.Name = "visitNotesDataGridViewTextBoxColumn";
            // 
            // tblVisitsBindingSource
            // 
            this.tblVisitsBindingSource.DataMember = "tblVisits";
            this.tblVisitsBindingSource.DataSource = this.dataSetVisits;
            // 
            // dataSetVisits
            // 
            this.dataSetVisits.DataSetName = "DataSetVisits";
            this.dataSetVisits.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(407, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "עדכון ביקור";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "הערות";
            // 
            // visitNotes
            // 
            this.visitNotes.Location = new System.Drawing.Point(12, 12);
            this.visitNotes.Multiline = true;
            this.visitNotes.Name = "visitNotes";
            this.visitNotes.Size = new System.Drawing.Size(284, 114);
            this.visitNotes.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "שעה";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "תאריך";
            // 
            // visitHour
            // 
            this.visitHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.visitHour.Location = new System.Drawing.Point(302, 103);
            this.visitHour.Name = "visitHour";
            this.visitHour.Size = new System.Drawing.Size(102, 20);
            this.visitHour.TabIndex = 18;
            // 
            // visitDate
            // 
            this.visitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.visitDate.Location = new System.Drawing.Point(302, 76);
            this.visitDate.Name = "visitDate";
            this.visitDate.Size = new System.Drawing.Size(102, 20);
            this.visitDate.TabIndex = 17;
            // 
            // visitpatiID
            // 
            this.visitpatiID.Location = new System.Drawing.Point(470, 106);
            this.visitpatiID.Name = "visitpatiID";
            this.visitpatiID.Size = new System.Drawing.Size(100, 20);
            this.visitpatiID.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "תז מטופל";
            // 
            // visitID
            // 
            this.visitID.Enabled = false;
            this.visitID.Location = new System.Drawing.Point(470, 79);
            this.visitID.Name = "visitID";
            this.visitID.Size = new System.Drawing.Size(100, 20);
            this.visitID.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "מספר ביקור";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(171, 132);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 84;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(252, 132);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 83;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(333, 132);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 82;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(414, 132);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 81;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // tblVisitsTableAdapter
            // 
            this.tblVisitsTableAdapter.ClearBeforeFill = true;
            // 
            // FormUpdateVisits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 429);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.visitNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.visitHour);
            this.Controls.Add(this.visitDate);
            this.Controls.Add(this.visitpatiID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.visitID);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateVisits";
            this.Text = "FormUpdateVisits";
            this.Load += new System.EventHandler(this.FormUpdateVisits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVisitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVisits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox visitNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker visitHour;
        private System.Windows.Forms.DateTimePicker visitDate;
        private System.Windows.Forms.TextBox visitpatiID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox visitID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private DataSetVisits dataSetVisits;
        private System.Windows.Forms.BindingSource tblVisitsBindingSource;
        private DataSetVisitsTableAdapters.tblVisitsTableAdapter tblVisitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitpatiIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitNotesDataGridViewTextBoxColumn;
    }
}