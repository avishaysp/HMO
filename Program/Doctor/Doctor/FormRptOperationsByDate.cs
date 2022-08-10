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
    public partial class FormRptOperationsByDate : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string patientDate;
        private string patiID;
        private string patientFirstName;
        private string patientLastName;
        private string patientReg;
        private string patientSci;
        private string saveColor = "";
        public FormRptOperationsByDate(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                counter = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   patoprPatiID, patoprName, patoprDate " +
                                          "FROM     tblPatientOperations   " +
                                          "WHERE    patoprDate BETWEEN #" + dateTimePicker1.Value.ToShortDateString() + "#  AND #" + dateTimePicker2.Value.ToShortDateString() + "#  " +
                                          "ORDER BY patoprID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patiID = dataReader.GetInt32(0).ToString();
                    patientReg = dataReader.GetString(1);
                    patientDate = dataReader.GetDateTime(2).ToShortDateString();
                    GetPati();
                    GetSci();
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

        private void GetPati()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   patientFirstName, patientLastName " +
                                          "FROM     tblPatients   " +
                                          "WHERE    patientID = " + patiID;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    patientFirstName = dataReader.GetString(0);
                    patientLastName = dataReader.GetString(1);
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

        private void GetSci()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   operationSciName " +
                                          "FROM     tblOperations   " +
                                          "WHERE    operationRegName = \"" + patientReg + "\"";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                if (dataReader.Read())
                {
                    patientSci = dataReader.GetString(0).ToString();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblOperations failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditListView()
        {
            try
            {
                string[] arr = new string[7];
                if (counter == 1)
                {
                    arr[0] = " מ " + dateTimePicker1.Value.ToShortDateString() + " עד " +  dateTimePicker2.Value.ToShortDateString() ;
                }
                arr[1] = patientDate;
                arr[2] = patiID;
                arr[3] = patientFirstName;
                arr[4] = patientLastName;
                arr[5] = patientReg;
                arr[6] = patientSci;
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
    }
}
