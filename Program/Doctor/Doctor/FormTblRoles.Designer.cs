namespace Doctor
{
    partial class FormTblRoles
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
            this.roleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRoles = new Doctor.DataSetRoles();
            this.button1 = new System.Windows.Forms.Button();
            this.tblRolesTableAdapter = new Doctor.DataSetRolesTableAdapters.tblRolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(38, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "טבלת תפקידים";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblRolesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(259, 257);
            this.dataGridView1.TabIndex = 1;
            // 
            // roleNameDataGridViewTextBoxColumn
            // 
            this.roleNameDataGridViewTextBoxColumn.DataPropertyName = "roleName";
            this.roleNameDataGridViewTextBoxColumn.HeaderText = "שם תפקיד";
            this.roleNameDataGridViewTextBoxColumn.Name = "roleNameDataGridViewTextBoxColumn";
            // 
            // tblRolesBindingSource
            // 
            this.tblRolesBindingSource.DataMember = "tblRoles";
            this.tblRolesBindingSource.DataSource = this.dataSetRoles;
            // 
            // dataSetRoles
            // 
            this.dataSetRoles.DataSetName = "DataSetRoles";
            this.dataSetRoles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "שמור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblRolesTableAdapter
            // 
            this.tblRolesTableAdapter.ClearBeforeFill = true;
            // 
            // FormTblRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 383);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "FormTblRoles";
            this.Text = "FormTblRoles";
            this.Load += new System.EventHandler(this.FormTblRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private DataSetRoles dataSetRoles;
        private System.Windows.Forms.BindingSource tblRolesBindingSource;
        private DataSetRolesTableAdapters.tblRolesTableAdapter tblRolesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleNameDataGridViewTextBoxColumn;
    }
}