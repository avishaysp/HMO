﻿using System;
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
    public partial class FormChartPatientAndVaccines : Form
    {
        private OleDbConnection dataConnection;
        private int counter;
        private string[] arrTypes;
        private int[] arrActual;
        public FormChartPatientAndVaccines(OleDbConnection dataConnection)
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
                                          "FROM     tblVaccines  ";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                counter = dataReader.GetInt32(0);
                dataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Count tblVaccines failed " +
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
                datacommand.CommandText = "SELECT   vaccineRegName " +
                                          "FROM     tblVaccines  " +
                                          "ORDER BY vaccineRegName";
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
                MessageBox.Show("Select tblVaccines failed " +
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
                datacommand.CommandText = "SELECT  patvacName " +
                                          "FROM    tblPatientVaccines  " +
                                          "WHERE   patvacName = \"" + arrTypes[idx] + "\"";
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                while (dataReader.Read())
                {
                    arrActual[idx]++;
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

        private void ShowChart()
        {
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            try
            {
                for (int i = 0; i < arrTypes.Length; i++)
                {
                    chart1.Series["חיסונים"].Points.AddXY(arrTypes[i], arrActual[i]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Show chart failed " +
                                 ex.Message, "Errors",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormChartPatientAndVaccines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientVaccines.tblPatientVaccines' table. You can move, or remove it, as needed.
            this.tblPatientVaccinesTableAdapter.Fill(this.dataSetPatientVaccines.tblPatientVaccines);

        }
    }
}
