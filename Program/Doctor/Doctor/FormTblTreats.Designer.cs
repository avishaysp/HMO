namespace Doctor
{
    partial class FormTblTreats
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
            this.treatRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTreats = new Doctor.DataSetTreats();
            this.button1 = new System.Windows.Forms.Button();
            this.tblTreatsTableAdapter = new Doctor.DataSetTreatsTableAdapters.tblTreatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת טיפולים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatRegNameDataGridViewTextBoxColumn,
            this.treatSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTreatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(249, 201);
            this.dataGridView1.TabIndex = 1;
            // 
            // treatRegNameDataGridViewTextBoxColumn
            // 
            this.treatRegNameDataGridViewTextBoxColumn.DataPropertyName = "treatRegName";
            this.treatRegNameDataGridViewTextBoxColumn.HeaderText = "שם טיפול";
            this.treatRegNameDataGridViewTextBoxColumn.Name = "treatRegNameDataGridViewTextBoxColumn";
            // 
            // treatSciNameDataGridViewTextBoxColumn
            // 
            this.treatSciNameDataGridViewTextBoxColumn.DataPropertyName = "treatSciName";
            this.treatSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.treatSciNameDataGridViewTextBoxColumn.Name = "treatSciNameDataGridViewTextBoxColumn";
            // 
            // tblTreatsBindingSource
            // 
            this.tblTreatsBindingSource.DataMember = "tblTreats";
            this.tblTreatsBindingSource.DataSource = this.dataSetTreats;
            // 
            // dataSetTreats
            // 
            this.dataSetTreats.DataSetName = "DataSetTreats";
            this.dataSetTreats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblTreatsTableAdapter
            // 
            this.tblTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblTreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 341);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblTreats";
            this.Text = "FormTblRoles";
            this.Load += new System.EventHandler(this.FormTblTreats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetTreats dataSetTreats;
        private System.Windows.Forms.BindingSource tblTreatsBindingSource;
        private DataSetTreatsTableAdapters.tblTreatsTableAdapter tblTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatSciNameDataGridViewTextBoxColumn;
    }
}