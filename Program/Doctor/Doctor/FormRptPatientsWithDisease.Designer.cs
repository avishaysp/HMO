namespace Doctor
{
    partial class FormRptPatientsWithDisease
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
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSetDrugs = new Doctor.DataSetDrugs();
            this.tblDrugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDrugsTableAdapter = new Doctor.DataSetDrugsTableAdapters.tblDrugsTableAdapter();
            this.dataSetDiseases = new Doctor.DataSetDiseases();
            this.tblDiseasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDiseasesTableAdapter = new Doctor.DataSetDiseasesTableAdapters.tblDiseasesTableAdapter();
            this.diseaseRegNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseSciNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(344, 83);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(75, 23);
            this.buttonColor.TabIndex = 180;
            this.buttonColor.Text = "צבע";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(263, 83);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 181;
            this.buttonClear.Text = "נקה";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(263, 111);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listView1.RightToLeftLayout = true;
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(810, 273);
            this.listView1.TabIndex = 179;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "שם תרופה";
            this.columnHeader1.Width = 84;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "תז";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "שם פרטי";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "שם משפחה";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "תאריך לידה";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "כתובת";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "עיר";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "טלפון";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "נייד";
            this.columnHeader9.Width = 62;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "מייל";
            this.columnHeader10.Width = 94;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diseaseRegNameDataGridViewTextBoxColumn,
            this.diseaseSciNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblDiseasesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(245, 273);
            this.dataGridView1.TabIndex = 178;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textbox
            // 
            this.textbox.Enabled = false;
            this.textbox.Location = new System.Drawing.Point(529, 56);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(100, 20);
            this.textbox.TabIndex = 177;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 176;
            this.label2.Text = "תרופה";
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(51, 82);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 175;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(132, 53);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 174;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(51, 53);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 173;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(132, 82);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 172;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(433, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 33);
            this.label1.TabIndex = 171;
            this.label1.Text = "דוח מטופלים עם תרופה";
            // 
            // dataSetDrugs
            // 
            this.dataSetDrugs.DataSetName = "DataSetDrugs";
            this.dataSetDrugs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDrugsBindingSource
            // 
            this.tblDrugsBindingSource.DataMember = "tblDrugs";
            this.tblDrugsBindingSource.DataSource = this.dataSetDrugs;
            // 
            // tblDrugsTableAdapter
            // 
            this.tblDrugsTableAdapter.ClearBeforeFill = true;
            // 
            // dataSetDiseases
            // 
            this.dataSetDiseases.DataSetName = "DataSetDiseases";
            this.dataSetDiseases.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDiseasesBindingSource
            // 
            this.tblDiseasesBindingSource.DataMember = "tblDiseases";
            this.tblDiseasesBindingSource.DataSource = this.dataSetDiseases;
            // 
            // tblDiseasesTableAdapter
            // 
            this.tblDiseasesTableAdapter.ClearBeforeFill = true;
            // 
            // diseaseRegNameDataGridViewTextBoxColumn
            // 
            this.diseaseRegNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseRegName";
            this.diseaseRegNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.diseaseRegNameDataGridViewTextBoxColumn.Name = "diseaseRegNameDataGridViewTextBoxColumn";
            this.diseaseRegNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diseaseSciNameDataGridViewTextBoxColumn
            // 
            this.diseaseSciNameDataGridViewTextBoxColumn.DataPropertyName = "diseaseSciName";
            this.diseaseSciNameDataGridViewTextBoxColumn.HeaderText = "שם מחלה";
            this.diseaseSciNameDataGridViewTextBoxColumn.Name = "diseaseSciNameDataGridViewTextBoxColumn";
            this.diseaseSciNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormRptPatientsWithDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 395);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label1);
            this.Name = "FormRptPatientsWithDisease";
            this.Text = "FormRptPatientsWithDisease";
            this.Load += new System.EventHandler(this.FormRptPatientsWithDisease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDrugsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDiseases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDiseasesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Label label1;
        private DataSetDrugs dataSetDrugs;
        private System.Windows.Forms.BindingSource tblDrugsBindingSource;
        private DataSetDrugsTableAdapters.tblDrugsTableAdapter tblDrugsTableAdapter;
        private DataSetDiseases dataSetDiseases;
        private System.Windows.Forms.BindingSource tblDiseasesBindingSource;
        private DataSetDiseasesTableAdapters.tblDiseasesTableAdapter tblDiseasesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseRegNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseSciNameDataGridViewTextBoxColumn;
    }
}