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
    public partial class FormRptDiseasesOfPatient : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string patientID;
        private string patientRecordID;
        private string patientDate;
        private string patientReg;
        private string patientSci;
        private int lastRow = 0;
        private string saveColor = "";
        public FormRptDiseasesOfPatient(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
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

        private void textboxPatientID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                counter = 0;
                patientID = textboxPatientID.Text;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   patdssID, patdssDate, patdssName " +
                                          "FROM     tblPatientDiseases   " +
                                          "WHERE    patdssPatiID = " + patientID + " " +
                                          "ORDER BY patdssID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patientRecordID = dataReader.GetInt32(0).ToString();
                    patientDate = dataReader.GetDateTime(1).ToShortDateString();
                    patientReg = dataReader.GetString(2);
                    GetSciName();
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPatientDiseases failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GetSciName()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   diseaseSciName " +
                                          "FROM     tblDiseases   " +
                                          "WHERE    diseaseRegName = \"" + patientReg + "\"";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    patientSci = dataReader.GetString(0).ToString();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPatientDiseases failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[6];
                if (counter == 1)
                {
                    arr[0] = patientID;
                }
                arr[1] = patientRecordID;
                arr[2] = patientDate;
                arr[3] = patientReg;
                arr[4] = patientSci;
                ListViewItem item = new ListViewItem(arr);
                if (saveColor != "")
                    item.ForeColor = Color.FromArgb(int.Parse(saveColor));
                listView1.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Edit listview item failed " + ex.Message, "Errors",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lastRow = dataGridView1.CurrentRow.Index;
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            FillSelectedRow();
        }

        private void FillSelectedRow()
        {
            try
            {
                textboxPatientID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                pictureBox1.ImageLocation = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                dataGridView1.CurrentCell = dataGridView1[0, lastRow];
                EnableButtons();
            }
            catch (Exception err)
            {
                MessageBox.Show("Fill Selected Row \n" + err.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }               

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            buttonColor.BackColor = cd.Color;
            saveColor = buttonColor.BackColor.ToArgb().ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void FormRptDiseasesOfPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatients.tblPatients' table. You can move, or remove it, as needed.
            this.tblPatientsTableAdapter.Fill(this.dataSetPatients.tblPatients);

        }

        
    }
}
