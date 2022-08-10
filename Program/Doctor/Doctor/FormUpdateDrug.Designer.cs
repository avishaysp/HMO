namespace Doctor
{
    partial class FormUpdateDrug
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
            this.drugRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drugSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetDrugs = new Doctor.DataSetDrugs();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drugSciName = new System.Windows.Forms.TextBox();
            this.drugRegName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblDrugsTableAdapter = new Doctor.DataSetDrugsTableAdapters.tblDrugsTableAdapter();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.drugRegNameDataGridViewTextBoxColumn,
            this.drugSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDrugsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 206);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(102, 378);
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
            this.label3.Location = new System.Drawing.Point(174, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "שם מדעי";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "שם תרופה";
            // 
            // drugSciName
            // 
            this.drugSciName.Location = new System.Drawing.Point(68, 82);
            this.drugSciName.Name = "drugSciName";
            this.drugSciName.Size = new System.Drawing.Size(100, 20);
            this.drugSciName.TabIndex = 9;
            // 
            // drugRegName
            // 
            this.drugRegName.Enabled = false;
            this.drugRegName.Location = new System.Drawing.Point(68, 55);
            this.drugRegName.Name = "drugRegName";
            this.drugRegName.Size = new System.Drawing.Size(100, 20);
            this.drugRegName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "עדכון תרופה";
            // 
            // tblDrugsTableAdapter
            // 
            this.tblDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(68, 108);
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
            this.buttonPrev.Location = new System.Drawing.Point(149, 137);
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
            this.buttonNext.Location = new System.Drawing.Point(68, 137);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 94;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(149, 108);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 93;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // FormUpdateDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 413);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drugSciName);
            this.Controls.Add(this.drugRegName);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateDrug";
            this.Text = "FormUpdateDrug";
            this.Load += new System.EventHandler(this.FormUpdateDrug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox drugSciName;
        private System.Windows.Forms.TextBox drugRegName;
        private System.Windows.Forms.Label label1;
        private DataSetDrugs dataSetDrugs;
        private System.Windows.Forms.BindingSource tblDrugsBindingSource;
        private DataSetDrugsTableAdapters.tblDrugsTableAdapter tblDrugsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn drugSciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}