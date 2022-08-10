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
    public partial class FormRptPatientsWithVaccine : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string regName;
        private string patientID;
        private string patientFirstName;
        private string patientLastName;
        private string patientBirthDate;
        private string patientAddress;
        private string patientCity;
        private string patientPhone;
        private string patientMobile;
        private string patientMail;
        private int lastRow = 0;
        private string saveColor = "";
        public FormRptPatientsWithVaccine(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                counter = 0;
                regName = textbox.Text;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   patvacPatientID  " +
                                          "FROM     tblPatientVaccines   " +
                                          "WHERE    patvacName = \"" + regName + "\" " +
                                          "ORDER BY patvacPatientID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patientID = dataReader.GetInt32(0).ToString();
                    GetPati();
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPatientVaccines failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GetPati()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   patientFirstName, patientLastName, patientBirthDate, patientAddress, patientCity, patientPhone, patientMobile, patientMail " +
                                          "FROM     tblPatients   " +
                                          "WHERE    patientID = " + patientID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    patientFirstName = dataReader.GetString(0);
                    patientLastName = dataReader.GetString(1);
                    patientBirthDate = dataReader.GetDateTime(2).ToString();
                    patientAddress = dataReader.GetString(3);
                    patientCity = dataReader.GetString(4);
                    patientPhone = dataReader.GetString(5);
                    patientMobile = dataReader.GetString(6);
                    patientMail = dataReader.GetString(7);
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblPatients failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[10];
                if (counter == 1)
                {
                    arr[0] = regName;
                }
                arr[1] = patientID;
                arr[2] = patientFirstName;
                arr[3] = patientLastName;
                arr[4] = patientBirthDate;
                arr[5] = patientAddress;
                arr[6] = patientCity;
                arr[7] = patientPhone;
                arr[8] = patientMobile;
                arr[9] = patientMail;
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

        private void EnableButtons()
        {
            buttonPrev.Enabled = true;
            buttonNext.Enabled = true;
            if (lastRow == 0)
                buttonPrev.Enabled = false;
            if (lastRow == dataGridView1.Rows.Count - 1)
                buttonNext.Enabled = false;
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
                textbox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

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

        private void FormRptPatientsWithVaccine_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetVaccines.tblVaccines' table. You can move, or remove it, as needed.
            this.tblVaccinesTableAdapter.Fill(this.dataSetVaccines.tblVaccines);

        }
    }
}
