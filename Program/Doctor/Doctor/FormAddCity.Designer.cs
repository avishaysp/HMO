namespace Doctor
{
    partial class FormAddCity
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
            this.cityName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblCitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetCities = new Doctor.DataSetCities();
            this.tblCitiesTableAdapter = new Doctor.DataSetCitiesTableAdapters.tblCitiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת עיר";
            // 
            // cityName
            // 
            this.cityName.Location = new System.Drawing.Point(44, 64);
            this.cityName.Name = "cityName";
            this.cityName.Size = new System.Drawing.Size(100, 20);
            this.cityName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "שם עיר";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(69, 402);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "הוסף";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCitiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(199, 302);
            this.dataGridView1.TabIndex = 4;
            // 
            // cityNameDataGridViewTextBoxColumn
            // 
            this.cityNameDataGridViewTextBoxColumn.DataPropertyName = "cityName";
            this.cityNameDataGridViewTextBoxColumn.HeaderText = "שם עיר";
            this.cityNameDataGridViewTextBoxColumn.Name = "cityNameDataGridViewTextBoxColumn";
            this.cityNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblCitiesBindingSource
            // 
            this.tblCitiesBindingSource.DataMember = "tblCities";
            this.tblCitiesBindingSource.DataSource = this.dataSetCities;
            // 
            // dataSetCities
            // 
            this.dataSetCities.DataSetName = "DataSetCities";
            this.dataSetCities.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCitiesTableAdapter
            // 
            this.tblCitiesTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 437);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cityName);
            this.Controls.Add(this.label1);
            this.Name = "FormAddCity";
            this.Text = "FormAddCity";
            this.Load += new System.EventHandler(this.FormAddClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetCities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cityName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSetCities dataSetCities;
        private System.Windows.Forms.BindingSource tblCitiesBindingSource;
        private DataSetCitiesTableAdapters.tblCitiesTableAdapter tblCitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityNameDataGridViewTextBoxColumn;
    }
}