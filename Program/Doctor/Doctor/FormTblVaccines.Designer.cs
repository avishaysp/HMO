namespace Doctor
{
    partial class FormTblVaccines
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vaccineRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccineSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblVaccinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetVaccines = new Doctor.DataSetVaccines();
            this.button1 = new System.Windows.Forms.Button();
            this.tblVaccinesTableAdapter = new Doctor.DataSetVaccinesTableAdapters.tblVaccinesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVaccinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVaccines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(63, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת חיסונים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccineRegNameDataGridViewTextBoxColumn,
            this.vaccineSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblVaccinesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(276, 269);
            this.dataGridView1.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblVaccinesTableAdapter
            // 
            this.tblVaccinesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblVaccines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblVaccines";
            this.Text = "FormTblVaccines";
            this.Load += new System.EventHandler(this.FormTblVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblVaccinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetVaccines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetVaccines dataSetVaccines;
        private System.Windows.Forms.BindingSource tblVaccinesBindingSource;
        private DataSetVaccinesTableAdapters.tblVaccinesTableAdapter tblVaccinesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vaccineSciNameDataGridViewTextBoxColumn;
    }
}