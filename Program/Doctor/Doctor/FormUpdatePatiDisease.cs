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
    public partial class FormUpdatePatiDisease : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        private int lastRow = 0;
        public FormUpdatePatiDisease(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                buttonUpdate.Enabled = false;
            FillPatiIDCombo();
            FillDiseaseCombo();
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
                    patdssPatiID.Items.Add(dataReader.GetInt32(0));
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
                    patdssName.Items.Add(dataReader.GetString(0));
                }
                dataReader.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill diseases combobox failed \n" + err.Message, "Error",
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
                                     "ORDER BY patdssID";
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlCommand, dataConnection);
                DataTable tbl = new DataTable();
                dataAdapter.Fill(tbl);
                dataGridView1.DataSource = tbl;
                dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception err)
            {
                MessageBox.Show("Refresh tblPatientDiseases table failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "UPDATE tblPatientDiseases  \n" +
                                          "SET     patdssPatiID           =  \"" + patdssPatiID.Text + "\" , \n" +
                                                  "patdssDate             =  \"" + patdssDate.Text + "\" , \n" +
                                                  "patdssName             =  \"" + patdssName.Text + "\"  \n" +
                                          "WHERE  patdssID = " + patdssID.Text;
                datacommand.ExecuteNonQuery();
                RefreshDataGridView();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                MessageBox.Show("Update tblPatientDiseases ended successfluly");
            }
            catch (Exception err)
            {
                MessageBox.Show("Update tblPatientDiseases failed \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillSelectedRow()
        {
            try
            {
                patdssID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                patdssPatiID.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                patdssDate.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                patdssName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
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

        private void FormUpdatePatiDisease_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientDiseases.tblPatientDiseases' table. You can move, or remove it, as needed.
            this.tblPatientDiseasesTableAdapter.Fill(this.dataSetPatientDiseases.tblPatientDiseases);

        }
    }
}
