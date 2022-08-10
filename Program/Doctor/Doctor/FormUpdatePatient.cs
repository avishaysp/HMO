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
    public partial class FormUpdatePatient : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdatePatient(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
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
                    patientCity.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill cities combobox failed \n" + err.Message, "Error",
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
                                     "FROM     tblPatients " +
                                     "ORDER BY patientID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblPatients table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormUpdatePatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatients.tblPatients' table. You can move, or remove it, as needed.
            this.tblPatientsTableAdapter.Fill(this.dataSetPatients.tblPatients);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblPatients  \n" +
                                          "SET    patientFirstName          =  \"" + patientFirstName.Text      + "\" , \n" +
                                                  "patientLastName          =  \"" + patientLastName.Text       + "\" , \n" +
                                                  "patientBirthDate         =  \"" + patientBirthDate.Text      + "\" , \n" +
                                                  "patientAddress           =  \"" + patientAddress.Text        + "\" , \n" +
                                                  "patientCity              =  \"" + patientCity.Text           + "\" , \n" +
                                                  "patientPhone             =  \"" + patientPhone.Text          + "\" , \n" +
                                                  "patientMobile            =  \"" + patientMobile.Text         + "\" , \n" +
                                                  "patientMail                 =  \"" + patientMail.Text           + "\" , \n" +
                                                  "patientPicture              =  \"" + patientPicture.Text        + "\"   \n" +
                                          "WHERE  patientID = " + patientID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblPatients ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblPatients failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                patientID.Text            = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                patientFirstName.Text     = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                patientLastName.Text      = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                patientBirthDate.Text     = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                patientAddress.Text       = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                patientCity.Text          = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                patientPhone.Text         = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                patientMobile.Text        = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                patientMail.Text          = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                patientPicture.Text       = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                pictureBox1.ImageLocation = patientPicture.Text;
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
            patientPicture.Text = pictureFileName;
        }
    }
}
