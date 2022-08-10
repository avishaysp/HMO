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
    public partial class FormRptVisitsOfPatient : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string patientID;
        private string patientRecordID;
        private string date;
        private string hour;
        private string notes;
        private int lastRow = 0;
        private string saveColor = "";
        public FormRptVisitsOfPatient(OleDbConnection dataConnection, bool isManager)
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
                datacommand.CommandText = "SELECT   visitID, visitDate, visitHour, visitNotes " +
                                          "FROM     tblVisits   " +
                                          "WHERE    visitpatiID = " + patientID + " " +
                                          "ORDER BY visitID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patientRecordID = dataReader.GetInt32(0).ToString();
                    date = dataReader.GetDateTime(1).ToShortDateString();
                    hour = dataReader.GetDateTime(2).ToShortTimeString();
                    notes = dataReader.GetString(3);
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPatientOperations failed " +
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
                arr[2] = date;
                arr[3] = hour;
                arr[4] = notes;
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

        private void FormRptVisitsOfPatients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatients.tblPatients' table. You can move, or remove it, as needed.
            this.tblPatientsTableAdapter.Fill(this.dataSetPatients.tblPatients);
        }
    }
}
