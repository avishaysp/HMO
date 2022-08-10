namespace Doctor
{
    partial class FormAddUser
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
            this.comboCity = new System.Windows.Forms.ComboBox();
            this.userID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIsManagerDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userMailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPictureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetUsers = new Doctor.DataSetUsers();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userMail = new System.Windows.Forms.TextBox();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tblUsersTableAdapter = new Doctor.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboRole = new System.Windows.Forms.ComboBox();
            this.userIsManager = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboCity
            // 
            this.comboCity.FormattingEnabled = true;
            this.comboCity.Location = new System.Drawing.Point(357, 75);
            this.comboCity.Name = "comboCity";
            this.comboCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboCity.Size = new System.Drawing.Size(158, 21);
            this.comboCity.TabIndex = 44;
            // 
            // userID
            // 
            this.userID.Location = new System.Drawing.Point(656, 49);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(124, 20);
            this.userID.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(786, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "תז משתמש";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.userFirstNameDataGridViewTextBoxColumn,
            this.userLastNameDataGridViewTextBoxColumn,
            this.userAddressDataGridViewTextBoxColumn,
            this.userCityDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn,
            this.userIsManagerDataGridViewCheckBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.userMobileDataGridViewTextBoxColumn,
            this.userMailDataGridViewTextBoxColumn,
            this.userPictureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(998, 280);
            this.dataGridView1.TabIndex = 41;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "תז משתמש";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userFirstNameDataGridViewTextBoxColumn
            // 
            this.userFirstNameDataGridViewTextBoxColumn.DataPropertyName = "userFirstName";
            this.userFirstNameDataGridViewTextBoxColumn.HeaderText = "שם פרטי";
            this.userFirstNameDataGridViewTextBoxColumn.Name = "userFirstNameDataGridViewTextBoxColumn";
            this.userFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userLastNameDataGridViewTextBoxColumn
            // 
            this.userLastNameDataGridViewTextBoxColumn.DataPropertyName = "userLastName";
            this.userLastNameDataGridViewTextBoxColumn.HeaderText = "שם משפחה";
            this.userLastNameDataGridViewTextBoxColumn.Name = "userLastNameDataGridViewTextBoxColumn";
            this.userLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userAddressDataGridViewTextBoxColumn
            // 
            this.userAddressDataGridViewTextBoxColumn.DataPropertyName = "userAddress";
            this.userAddressDataGridViewTextBoxColumn.HeaderText = "כתובת";
            this.userAddressDataGridViewTextBoxColumn.Name = "userAddressDataGridViewTextBoxColumn";
            this.userAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userCityDataGridViewTextBoxColumn
            // 
            this.userCityDataGridViewTextBoxColumn.DataPropertyName = "userCity";
            this.userCityDataGridViewTextBoxColumn.HeaderText = "עיר";
            this.userCityDataGridViewTextBoxColumn.Name = "userCityDataGridViewTextBoxColumn";
            this.userCityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "סיסמה";
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            this.userPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "userRole";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "תפקיד";
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            this.userRoleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIsManagerDataGridViewCheckBoxColumn
            // 
            this.userIsManagerDataGridViewCheckBoxColumn.DataPropertyName = "userIsManager";
            this.userIsManagerDataGridViewCheckBoxColumn.HeaderText = "מנהל";
            this.userIsManagerDataGridViewCheckBoxColumn.Name = "userIsManagerDataGridViewCheckBoxColumn";
            this.userIsManagerDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "userPhone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "טלפון";
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            this.userPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userMobileDataGridViewTextBoxColumn
            // 
            this.userMobileDataGridViewTextBoxColumn.DataPropertyName = "userMobile";
            this.userMobileDataGridViewTextBoxColumn.HeaderText = "נייד";
            this.userMobileDataGridViewTextBoxColumn.Name = "userMobileDataGridViewTextBoxColumn";
            this.userMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userMailDataGridViewTextBoxColumn
            // 
            this.userMailDataGridViewTextBoxColumn.DataPropertyName = "userMail";
            this.userMailDataGridViewTextBoxColumn.HeaderText = "מייל";
            this.userMailDataGridViewTextBoxColumn.Name = "userMailDataGridViewTextBoxColumn";
            this.userMailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userPictureDataGridViewTextBoxColumn
            // 
            this.userPictureDataGridViewTextBoxColumn.DataPropertyName = "userPicture";
            this.userPictureDataGridViewTextBoxColumn.HeaderText = "תמונה";
            this.userPictureDataGridViewTextBoxColumn.Name = "userPictureDataGridViewTextBoxColumn";
            this.userPictureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.dataSetUsers;
            // 
            // dataSetUsers
            // 
            this.dataSetUsers.DataSetName = "DataSetUsers";
            this.dataSetUsers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 106);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 67);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "הוספת משתמש";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 69);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(49, 31);
            this.buttonBrowse.TabIndex = 39;
            this.buttonBrowse.Text = "...עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "תמונה";
            // 
            // pictureLocation
            // 
            this.pictureLocation.Location = new System.Drawing.Point(67, 75);
            this.pictureLocation.Name = "pictureLocation";
            this.pictureLocation.Size = new System.Drawing.Size(220, 20);
            this.pictureLocation.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(521, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "מייל";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(521, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "נייד";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(521, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "טלפון";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "עיר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(786, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "כתובת";
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(357, 153);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(158, 20);
            this.userMail.TabIndex = 30;
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(357, 127);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(158, 20);
            this.userMobile.TabIndex = 29;
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(357, 101);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(158, 20);
            this.userPhone.TabIndex = 28;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(580, 153);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(200, 20);
            this.userAddress.TabIndex = 27;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(656, 101);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(124, 20);
            this.userLastName.TabIndex = 26;
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(656, 75);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(124, 20);
            this.userFirstName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(786, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "שם משפחה";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(786, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "שם פרטי";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "הוספת משתמש";
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(656, 127);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(124, 20);
            this.userPassword.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(786, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "סיסמה";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(291, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "תפקיד";
            // 
            // comboRole
            // 
            this.comboRole.FormattingEnabled = true;
            this.comboRole.Location = new System.Drawing.Point(140, 101);
            this.comboRole.Name = "comboRole";
            this.comboRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboRole.Size = new System.Drawing.Size(145, 21);
            this.comboRole.TabIndex = 48;
            // 
            // userIsManager
            // 
            this.userIsManager.AutoSize = true;
            this.userIsManager.Location = new System.Drawing.Point(279, 132);
            this.userIsManager.Name = "userIsManager";
            this.userIsManager.Size = new System.Drawing.Size(52, 17);
            this.userIsManager.TabIndex = 49;
            this.userIsManager.Text = "מנהל";
            this.userIsManager.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(854, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 463);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userIsManager);
            this.Controls.Add(this.comboRole);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.comboCity);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userMail);
            this.Controls.Add(this.userMobile);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddUser";
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCity;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pictureLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataSetUsers dataSetUsers;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private DataSetUsersTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userIsManagerDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userMailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPictureDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboRole;
        private System.Windows.Forms.CheckBox userIsManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}