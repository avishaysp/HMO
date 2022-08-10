namespace Doctor
{
    partial class FormUpdateTreats
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
            this.treatRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTreatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTreats = new Doctor.DataSetTreats();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.treatSciName = new System.Windows.Forms.TextBox();
            this.treatRegName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblTreatsTableAdapter = new Doctor.DataSetTreatsTableAdapters.tblTreatsTableAdapter();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.treatRegNameDataGridViewTextBoxColumn,
            this.treatSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTreatsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(260, 225);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(100, 413);
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
            this.label3.Location = new System.Drawing.Point(194, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "שם מדעי";
            // 
            // treatSciName
            // 
            this.treatSciName.Location = new System.Drawing.Point(88, 98);
            this.treatSciName.Name = "treatSciName";
            this.treatSciName.Size = new System.Drawing.Size(100, 20);
            this.treatSciName.TabIndex = 10;
            // 
            // treatRegName
            // 
            this.treatRegName.Enabled = false;
            this.treatRegName.Location = new System.Drawing.Point(88, 71);
            this.treatRegName.Name = "treatRegName";
            this.treatRegName.Size = new System.Drawing.Size(100, 20);
            this.treatRegName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "שם טיפול";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(56, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "עדכון טיפול";
            // 
            // tblTreatsTableAdapter
            // 
            this.tblTreatsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(62, 124);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 92;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(143, 153);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 91;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(62, 153);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 90;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(143, 124);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 89;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // FormUpdateTreats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 446);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treatSciName);
            this.Controls.Add(this.treatRegName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateTreats";
            this.Text = "FormUpdateTreats";
            this.Load += new System.EventHandler(this.FormUpdateTreats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTreatsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTreats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox treatSciName;
        private System.Windows.Forms.TextBox treatRegName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSetTreats dataSetTreats;
        private System.Windows.Forms.BindingSource tblTreatsBindingSource;
        private DataSetTreatsTableAdapters.tblTreatsTableAdapter tblTreatsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatSciNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
    }
}