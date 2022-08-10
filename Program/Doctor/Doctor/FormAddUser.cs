using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Doctor
{
    public partial class FormAddUser : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddUser(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonAdd.Enabled = false;
            FillCityCombo();
            FillRolesCombo();
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {            
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }

        private void buttonAdd_Click(object sender, EventArgs e)                   // Add student to table
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblUsers " +
                                     "(userID, userFirstName, userLastName, userAddress, userCity, userPassword, userRole, userIsManager, userPhone, userMobile, userMail, userPicture) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", {7}, \"{8}\", \"{9}\", \"{10}\", \"{11}\")",
                                       userID.Text, userFirstName.Text, userLastName.Text, userAddress.Text, comboCity.Text,
                                       userPassword.Text, comboRole.Text, userIsManager.Checked, userPhone.Text, userMobile.Text, userMail.Text, pictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblUsers ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblUsers failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string sqlCommand = "SELECT   * " +
                                     "FROM     tblUsers " +
                                     "ORDER BY userID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh dataGridView failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillCityCombo()                                   // Populate cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT cityName " +
                                          "FROM tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillRolesCombo()                                   // Populate Roles combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT roleName " +
                                          "FROM tblRoles " +
                                          "ORDER BY roleName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboRole.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            pictureLocation.Text = pictureFileName;
        }
                
    }
}
