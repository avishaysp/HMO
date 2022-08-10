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
    public partial class FormAddPatiOperation : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormAddPatiOperation(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonAdd.Enabled = false;
            FillPatiIDCombo();
            FillOperationCombo();
        }

        private void FormAddPatiOperation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientOperations.tblPatientOperations' table. You can move, or remove it, as needed.
            this.tblPatientOperationsTableAdapter.Fill(this.dataSetPatientOperations.tblPatientOperations);
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

        private void FillOperationCombo()                                   // Populate operations combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT operationRegName " +
                                          "FROM tblOperations " +
                                          "ORDER BY operationRegName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    comboBoxOperation.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill operations combobox failed \n" + err.Message, "Error",
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
                                    ("INSERT INTO tblPatientOperations " +
                                     "( patoprPatiID, patoprDate, patoprName) " +
                                     " VALUES ( {0}, \"{1}\", \"{2}\")",
                                       comboBoxPatiID.Text, patoprDate.Text, comboBoxOperation.Text);
                datacommand.CommandText = str;
                datacommand.ExecuteNonQuery();
                MessageBox.Show("Insert into tblPatientOperations ended successfully");
                RefreshDataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show("Insert into tblPatientOperations failed \n" + err.Message, "Error",
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
                                     "FROM     tblPatientOperations " +
                                     "ORDER BY patoprPatiID";
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

        private void patoprDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
