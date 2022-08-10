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
    public partial class FormTblTreats : Form
    {
        private bool isManager;
        public FormTblTreats(bool isManager)
        {
            InitializeComponent();
            this.isManager = isManager;
            if (!isManager)
                button1.Enabled = false;
        }

        private void FormTblTreats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetTreats.tblTreats' table. You can move, or remove it, as needed.
            this.tblTreatsTableAdapter.Fill(this.dataSetTreats.tblTreats);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataSetTreats changes = (DataSetTreats)dataSetTreats.GetChanges();
                if (changes == null)
                    return;
                // check for errors
                DataTable dt = changes.tblTreats.GetChanges();
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
                int numRows = tblTreatsTableAdapter.Update(changes);
                MessageBox.Show("Updated " + numRows + " rows", "Success");
                dataSetTreats.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Erros",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataSetTreats.RejectChanges();
            }
        }
    }
}
