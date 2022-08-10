using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class FormTblPatientVaccines : Form
    {
        private bool isManager;
        public FormTblPatientVaccines(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
                button1.Enabled = false;
        }

        private void FormTblPatientVaccines_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetPatientVaccines.tblPatientVaccines' table. You can move, or remove it, as needed.
            this.tblPatientVaccinesTableAdapter.Fill(this.dataSetPatientVaccines.tblPatientVaccines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetPatientVaccines changes = (DataSetPatientVaccines)dataSetPatientVaccines.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblPatientVaccines.GetChanges();
                DataRow[] badRows = dt.GetErrors();
                //find the errors and tell the user
                if (badRows.Length > 0)
                {
                    string errorMsg = "";
                    foreach (DataRow row in badRows)
                    {
                        foreach (DataColumn col in row.GetColumnsInError())
                        {
                            errorMsg = errorMsg + row.GetColumnsInError() + "\n";
                        }
                    }
                    MessageBox.Show("Errors in data: " + errorMsg,
                        "Please fix", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //no error found, update the database
                int numRows = tblPatientVaccinesTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetPatientVaccines.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetPatientVaccines.RejectChanges();
            }
        }
    }
}
