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
    public partial class FormUpdateUser : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdateUser(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillRoleCombo();
            FillCityCombo();
            RefreshDataGridView();
        }

        private void FillCityCombo()                   // fill cities combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   cityName " +
                                          "FROM     tblCities " +
                                          "ORDER BY cityName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    userCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillRoleCombo()                   // fill roles combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   roleName " +
                                          "FROM     tblRoles " +
                                          "ORDER BY roleName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    userRole.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill roles combobox failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void FormUpdateUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetUsers.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.dataSetUsers.tblUsers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
        }

        private void FillSelectedRow()
        {
            try
            {
                userID.Text               = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                userFirstName.Text        = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                userLastName.Text         = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                userAddress.Text          = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                userCity.Text             = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                userPassword.Text         = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                userRole.Text             = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                userIsManager.Checked     = dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "True";
                userPhone.Text            = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                userMobile.Text           = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                userMail.Text             = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                userPicture.Text          = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                pictureBox1.ImageLocation = userPicture.Text;
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow++;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows[lastRow].Selected = true;
            FillSelectedRow();

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = openFileDialog1.ShowDialog();
            string pictureFileName = openFileDialog1.FileName;
            pictureBox1.ImageLocation = pictureFileName;
            userPicture.Text = pictureFileName;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblUsers  \n" +
                                          "SET    userFirstName          =  \"" + userFirstName.Text    + "\" , \n" +
                                                  "userLastName          =  \"" + userLastName.Text     + "\" , \n" +
                                                  "userAddress           =  \"" + userAddress.Text      + "\" , \n" +
                                                  "userCity              =  \"" + userCity.Text         + "\" , \n" +
                                                  "userPassword          =  \"" + userPassword.Text     + "\" , \n" +
                                                  "userRole              =  \"" + userRole.Text         + "\" , \n" +
                                                  "userIsManager         =    " + userIsManager.Checked + "   , \n" +
                                                  "userPhone             =  \"" + userPhone.Text        + "\" , \n" +
                                                  "userMobile            =  \"" + userMobile.Text       + "\" , \n" +
                                                  "userMail              =  \"" + userMail.Text         + "\" , \n" +
                                                  "userPicture           =  \"" + userPicture.Text      + "\"   \n" +
                                          "WHERE  userID = " + userID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblUsers ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblUsers failed \n" + err.Message, "Error",
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
                MessageBox.Show("Refresh tblUsers table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
