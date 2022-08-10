namespace Doctor
{
    partial class FormUpdateUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userID = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userAddress = new System.Windows.Forms.TextBox();
            this.userPassword = new System.Windows.Forms.TextBox();
            this.userRole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userCity = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.userPhone = new System.Windows.Forms.TextBox();
            this.userIsManager = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.userMobile = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userMail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.userPicture = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tblUsersTableAdapter = new Doctor.DataSetUsersTableAdapters.tblUsersTableAdapter();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.buttonLast = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(902, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "תז";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "שם פרטי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "כתובת";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(902, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "שם משפחה";
            // 
            // userID
            // 
            this.userID.Enabled = false;
            this.userID.Location = new System.Drawing.Point(796, 76);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(100, 20);
            this.userID.TabIndex = 1;
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(796, 103);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(100, 20);
            this.userFirstName.TabIndex = 2;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(796, 129);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(100, 20);
            this.userLastName.TabIndex = 3;
            // 
            // userAddress
            // 
            this.userAddress.Location = new System.Drawing.Point(612, 76);
            this.userAddress.Name = "userAddress";
            this.userAddress.Size = new System.Drawing.Size(100, 20);
            this.userAddress.TabIndex = 4;
            // 
            // userPassword
            // 
            this.userPassword.Location = new System.Drawing.Point(612, 129);
            this.userPassword.Name = "userPassword";
            this.userPassword.Size = new System.Drawing.Size(100, 20);
            this.userPassword.TabIndex = 5;
            // 
            // userRole
            // 
            this.userRole.FormattingEnabled = true;
            this.userRole.Location = new System.Drawing.Point(445, 76);
            this.userRole.Name = "userRole";
            this.userRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userRole.Size = new System.Drawing.Size(100, 21);
            this.userRole.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "עיר";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(718, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "סיסמה";
            // 
            // userCity
            // 
            this.userCity.FormattingEnabled = true;
            this.userCity.Location = new System.Drawing.Point(612, 103);
            this.userCity.Name = "userCity";
            this.userCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userCity.Size = new System.Drawing.Size(100, 21);
            this.userCity.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "תפקיד";
            // 
            // userPhone
            // 
            this.userPhone.Location = new System.Drawing.Point(445, 129);
            this.userPhone.Name = "userPhone";
            this.userPhone.Size = new System.Drawing.Size(100, 20);
            this.userPhone.TabIndex = 10;
            // 
            // userIsManager
            // 
            this.userIsManager.AutoSize = true;
            this.userIsManager.Location = new System.Drawing.Point(536, 105);
            this.userIsManager.Name = "userIsManager";
            this.userIsManager.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userIsManager.Size = new System.Drawing.Size(52, 17);
            this.userIsManager.TabIndex = 11;
            this.userIsManager.Text = "מנהל";
            this.userIsManager.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "טלפון";
            // 
            // userMobile
            // 
            this.userMobile.Location = new System.Drawing.Point(254, 76);
            this.userMobile.Name = "userMobile";
            this.userMobile.Size = new System.Drawing.Size(121, 20);
            this.userMobile.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(381, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "נייד";
            // 
            // userMail
            // 
            this.userMail.Location = new System.Drawing.Point(254, 103);
            this.userMail.Name = "userMail";
            this.userMail.Size = new System.Drawing.Size(121, 20);
            this.userMail.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "מייל";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(381, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "תמונה";
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(254, 129);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(121, 20);
            this.userPicture.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(89, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(13, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(996, 224);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "תז";
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
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(463, 420);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "עדכן";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(12, 79);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(71, 105);
            this.buttonBrowse.TabIndex = 22;
            this.buttonBrowse.Text = "עיון";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.Location = new System.Drawing.Point(408, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 33);
            this.label12.TabIndex = 23;
            this.label12.Text = "עדכון משתמש";
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonFirst
            // 
            this.buttonFirst.Location = new System.Drawing.Point(589, 161);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 24;
            this.buttonFirst.Text = "ראשון";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.Location = new System.Drawing.Point(508, 161);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 24;
            this.buttonNext.Text = "הבא";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.Enabled = false;
            this.buttonPrev.Location = new System.Drawing.Point(427, 161);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(75, 23);
            this.buttonPrev.TabIndex = 24;
            this.buttonPrev.Text = "הקודם";
            this.buttonPrev.UseVisualStyleBackColor = true;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // buttonLast
            // 
            this.buttonLast.Location = new System.Drawing.Point(346, 161);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 24;
            this.buttonLast.Text = "אחרון";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 455);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.userMail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userMobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.userIsManager);
            this.Controls.Add(this.userPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.userCity);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userAddress);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormUpdateUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FormUpdateUser";
            this.Load += new System.EventHandler(this.FormUpdateUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userID;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userAddress;
        private System.Windows.Forms.TextBox userPassword;
        private System.Windows.Forms.ComboBox userRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox userCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userPhone;
        private System.Windows.Forms.CheckBox userIsManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userMobile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userMail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}