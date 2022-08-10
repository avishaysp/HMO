using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Doctor
{
    public partial class FormAddPatient : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddPatient(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonAdd.Enabled = false;
            FillCityCombo();

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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                string str = string.Format
                                    ("INSERT INTO tblPatients " +
                                     "(patientId, patientFirstName, patientLastName, patientBirthDate, patientAddress, patientCity, patientPhone, patientMobile, patientMail, patientPicture) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\", \"{3}\", \"{4}\", \"{5}\", \"{6}\", \"{7}\", \"{8}\", \"{9}\")",
                                       patID.Text, patFirstName.Text, patLastName.Text, patBirthDate.Text,
                                       patAddress.Text, comboCity.Text, patPhone.Text, patMobile.Text, patMail, pictureLocation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblPatients ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblPatients failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormAddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatients.tblPatients' table. You can move, or remove it, as needed.
            this.tblPatientsTableAdapter.Fill(this.dataSetPatients.tblPatients);

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
