namespace Doctor
{
    partial class FormTblDrugs
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.drugRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDrugs = new Doctor.DataSetDrugs();
            this.label1 = new System.Windows.Forms.Label();
            this.tblDrugsTableAdapter = new Doctor.DataSetDrugsTableAdapters.tblDrugsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugRegNameDataGridViewTextBoxColumn,
            this.drugSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(258, 254);
            this.dataGridView1.TabIndex = 1;
            // 
            // drugRegNameDataGridViewTextBoxColumn
            // 
            this.drugRegNameDataGridViewTextBoxColumn.DataPropertyName = "drugRegName";
            this.drugRegNameDataGridViewTextBoxColumn.HeaderText = "שם תרופה";
            this.drugRegNameDataGridViewTextBoxColumn.Name = "drugRegNameDataGridViewTextBoxColumn";
            // 
            // drugSciNameDataGridViewTextBoxColumn
            // 
            this.drugSciNameDataGridViewTextBoxColumn.DataPropertyName = "drugSciName";
            this.drugSciNameDataGridViewTextBoxColumn.HeaderText = "שם מדעי";
            this.drugSciNameDataGridViewTextBoxColumn.Name = "drugSciNameDataGridViewTextBoxColumn";
            // 
            // tblDrugsBindingSource
            // 
            this.tblDrugsBindingSource.DataMember = "tblDrugs";
            this.tblDrugsBindingSource.DataSource = this.dataSetDrugs;
            // 
            // dataSetDrugs
            // 
            this.dataSetDrugs.DataSetName = "DataSetDrugs";
            this.dataSetDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(52, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "טבלת תרופות";
            // 
            // tblDrugsTableAdapter
            // 
            this.tblDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblDrugs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormTblDrugs";
            this.Text = "FormTblDrugs";
            this.Load += new System.EventHandler(this.FormTblDrugs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private DataSetDrugs dataSetDrugs;
        private System.Windows.Forms.BindingSource tblDrugsBindingSource;
        private DataSetDrugsTableAdapters.tblDrugsTableAdapter tblDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugSciNameDataGridViewTextBoxColumn;
    }
}