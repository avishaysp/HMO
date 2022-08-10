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
    public partial class FormChartPatientAndOperations : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrTypes;
        private int[] arrActual;
        public FormChartPatientAndOperations(OleDbConnection dataConnection)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            CountTypes();
            arrTypes = new string[counter];
            arrActual = new int[counter];
            FillArrTypes();
            FillArrActual();
            ShowChart();
        }

        private void CountTypes()
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   COUNT(*) " +
                                          "FROM     tblOperations  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblOperations failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillArrTypes()
        {
            try
            {
                int k = 0;
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT   operationRegName " +
                                          "FROM     tblOperations  " +
                                          "ORDER BY operationRegName";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrTypes[k] = dataReader.GetString(0);
                    k++;
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

        private void FillArrActual()
        {
            for (int idx = 0; idx < arrTypes.Length; idx++)
                CountActual(idx);
        }

        private void CountActual(int idx)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  patoprName " +
                                          "FROM    tblPatientOperations  " +
                                          "WHERE   patoprName = \"" + arrTypes[idx] + "\"";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrActual[idx]++;
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

        private void ShowChart()
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            try
            {
                for (int i = 0; i < arrTypes.Length; i++)
                {
                    chart1.Series["ניתוחים"].Points.AddXY(arrTypes[i], arrActual[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChartPatientAndOperations_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientOperations.tblPatientOperations' table. You can move, or remove it, as needed.
            this.tblPatientOperationsTableAdapter.Fill(this.dataSetPatientOperations.tblPatientOperations);

        }
    }
}
