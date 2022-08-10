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
    public partial class FormAddPatiDisease : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddPatiDisease(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonAdd.Enabled = false;
            FillPatiIDCombo();
            //FillVisitCombo();
            FillDiseaseCombo();
        }

        private void FormAddPatiDisease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientDiseases.tblPatientDiseases' table. You can move, or remove it, as needed.
            this.tblPatientDiseasesTableAdapter.Fill(this.dataSetPatientDiseases.tblPatientDiseases);
        }

        private void FillPatiIDCombo()                                   // Populate IDs combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT patientID " +
                                          "FROM tblPatients " +
                                          "ORDER BY patientID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxPatiID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill IDs combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDiseaseCombo()                                   // Populate disease combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT diseaseRegName " +
                                          "FROM tblDiseases " +
                                          "ORDER BY diseaseRegName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxDisease.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill diseases combobox failed \n" + err.Message, "Error",
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
                                    ("INSERT INTO tblPatientDiseases " +
                                     "(patdssPatiID, patdssDate, patdssName) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\")",
                                       comboBoxPatiID.Text, patdssDate.Text, comboBoxDisease.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblPatientDiseases ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblPatientDiseases failed \n" + err.Message, "Error",
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
                                     "FROM     tblPatientDiseases " +
                                     "ORDER BY patdssPatiID";
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
    }
}
