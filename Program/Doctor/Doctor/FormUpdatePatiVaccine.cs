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
    public partial class FormUpdatePatiVaccine : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdatePatiVaccine(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillPatiIDCombo();
            FillVaccineCombo();
            RefreshDataGridView();
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
                    patvacPatientID.Items.Add(dataReader.GetInt32(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill IDs combobox failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillVaccineCombo()                                   // Populate vaccine combobox
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT vaccineRegName " +
                                          "FROM tblVaccines " +
                                          "ORDER BY vaccineRegName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patvacName.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill vaccine combobox failed \n" + err.Message, "Error",
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
                                     "FROM     tblPatientVaccines " +
                                     "ORDER BY patvacID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblPatientVaccines table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblPatientVaccines  \n" +
                                          "SET     patvacPatientID        =  \"" + patvacPatientID.Text + "\" , \n" +
                                                  "patvacDate             =  \"" + patvacDate.Text      + "\" , \n" +
                                                  "patvacName             =  \"" + patvacName.Text      + "\"   \n" +
                                          "WHERE  patvacID = " + patvacID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblPatientVaccines ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblPatientVaccines failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSelectedRow()
        {
            try
            {
                patvacID.Text        = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                patvacPatientID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                patvacDate.Text      = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                patvacName.Text      = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
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
            buttonPrev.Enabled = false;
            buttonNext.Enabled = false;
            if (lastRow != 0)
                buttonPrev.Enabled = true;
            if (lastRow != dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = true;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow = 0;
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

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[lastRow].Selected = false;
            lastRow--;
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

        private void FormUpdatePatiVaccine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientVaccines.tblPatientVaccines' table. You can move, or remove it, as needed.
            this.tblPatientVaccinesTableAdapter.Fill(this.dataSetPatientVaccines.tblPatientVaccines);

        }
    }
}
