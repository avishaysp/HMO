namespace Doctor
{
    partial class FormUpdateVaccine
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vaccineRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVaccines = new Doctor.DataSetVaccines();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vaccineSciName = new System.Windows.Forms.TextBox();
            this.vaccineRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblVaccinesTableAdapter = new Doctor.DataSetVaccinesTableAdapters.tblVaccinesTableAdapter();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccineRegNameDataGridViewTextBoxColumn,
            this.vaccineSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 218);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // vaccineRegNameDataGridViewTextBoxColumn
            // 
            this.vaccineRegNameDataGridViewTextBoxColumn.DataPropertyName = "vaccineRegName";
            this.vaccineRegNameDataGridViewTextBoxColumn.HeaderText = "שם חיסון";
            this.vaccineRegNameDataGridViewTextBoxColumn.Name = "vaccineRegNameDataGridViewTextBoxColumn";
            // 
            // vaccineSciNameDataGridViewTextBoxColumn
            // 
            this.vaccineSciNameDataGridViewTextBoxColumn.DataPropertyName = "vaccineSciName";
            this.vaccineSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.vaccineSciNameDataGridViewTextBoxColumn.Name = "vaccineSciNameDataGridViewTextBoxColumn";
            // 
            // tblVaccinesBindingSource
            // 
            this.tblVaccinesBindingSource.DataMember = "tblVaccines";
            this.tblVaccinesBindingSource.DataSource = this.dataSetVaccines;
            // 
            // dataSetVaccines
            // 
            this.dataSetVaccines.DataSetName = "DataSetVaccines";
            this.dataSetVaccines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(101, 407);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 12;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "שם מדעי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "שם חיסון";
            // 
            // vaccineSciName
            // 
            this.vaccineSciName.Location = new System.Drawing.Point(67, 99);
            this.vaccineSciName.Name = "vaccineSciName";
            this.vaccineSciName.Size = new System.Drawing.Size(100, 20);
            this.vaccineSciName.TabIndex = 9;
            // 
            // vaccineRegName
            // 
            this.vaccineRegName.Enabled = false;
            this.vaccineRegName.Location = new System.Drawing.Point(67, 72);
            this.vaccineRegName.Name = "vaccineRegName";
            this.vaccineRegName.Size = new System.Drawing.Size(100, 20);
            this.vaccineRegName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(58, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "עדכון חיסון";
            // 
            // tblVaccinesTableAdapter
            // 
            this.tblVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(64, 125);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 96;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(145, 154);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 95;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(64, 154);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 94;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(145, 125);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 93;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // FormUpdateVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 443);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vaccineSciName);
            this.Controls.Add(this.vaccineRegName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateVaccine";
            this.Text = "FormUdateVaccine";
            this.Load += new System.EventHandler(this.FormUdateVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vaccineSciName;
        private System.Windows.Forms.TextBox vaccineRegName;
        private System.Windows.Forms.Label label1;
        private DataSetVaccines dataSetVaccines;
        private System.Windows.Forms.BindingSource tblVaccinesBindingSource;
        private DataSetVaccinesTableAdapters.tblVaccinesTableAdapter tblVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineSciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}