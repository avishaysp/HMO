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
    public partial class FormRptVisitsByDate : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string patientDate;
        private string patiID;
        private string visitID;
        private string visitNotes;
        private string patientFirstName;
        private string patientLastName;
        private string saveColor = "";
        public FormRptVisitsByDate(OleDbConnection dataConnection, bool isManager)
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
                datacommand.CommandText = "SELECT   visitpatiID, visitID, visitNotes, visitDate " +
                                          "FROM     tblVisits   " +
                                          "WHERE    visitDate BETWEEN #" + dateTimePicker1.Value.ToShortDateString() + "#  AND #" + dateTimePicker2.Value.ToShortDateString() + "#  " +
                                          "ORDER BY visitID";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    patiID = dataReader.GetInt32(0).ToString();
                    visitID = dataReader.GetInt32(1).ToString();
                    visitNotes = dataReader.GetString(2);
                    patientDate = dataReader.GetDateTime(3).ToShortDateString();
                    GetPati();
                    counter++;
                    EditListView();
                }
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select tblVisits failed " +
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

        
        private void EditListView()
        {
            try
            {
                string[] arr = new string[7];
                if (counter == 1)
                {
                    arr[0] = " מ " + dateTimePicker1.Value.ToShortDateString() + " עד " + dateTimePicker2.Value.ToShortDateString();
                }
                arr[1] = patientDate;
                arr[2] = visitID;
                arr[3] = visitNotes;
                arr[4] = patiID;
                arr[5] = patientFirstName;
                arr[6] = patientLastName;
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
