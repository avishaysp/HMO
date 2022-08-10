using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Doctor
{
    public partial class FormLogin : Form
    {
        private OleDbConnection dataConnection;
        private string firstName, lastName, password, line, pictureLocation;
        int id;
        bool isManager;

        public FormLogin()
        {
            InitializeComponent();
            OpenDb();
        }
        private void OpenDb()                                    //Open data base
        {
            dataConnection = new OleDbConnection();
            try
            {
                dataConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Projects_2016\\Project_AvishaySpitzer\\Access\\dbDoctor.accdb";
                dataConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open data base failed" + ex.Message,
                                 "Errors",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
        }
    }

        private void loginEnter_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand datacommand = new OleDbCommand();
                datacommand.Connection = dataConnection;
                datacommand.CommandText = "SELECT  userID, userFirstName, userLastName, userPassword, userIsManager, userPicture " +
                                          "FROM    tblUsers " +
                                          "WHERE   userID = " + loginID.Text;
                OleDbDataReader dataReader = datacommand.ExecuteReader();
                dataReader.Read();
                id = dataReader.GetInt32(0);
                firstName = dataReader.GetString(1);
                lastName = dataReader.GetString(2);
                password = dataReader.GetString(3);
                isManager = dataReader.GetBoolean(4);
                pictureLocation = dataReader.GetString(5);
                if (password == loginPassword.Text)
                {
                    loginMessage.Text = "שלום," + " " + firstName + " " + lastName;
                    loginEnter.Visible = false;
                    loginContinue.Visible = true;
                    loginID.Enabled = false;
                    loginPassword.Enabled = false;
                    pictureBox1.ImageLocation = pictureLocation;
                }
                else
                {
                    MessageBox.Show("Invalid password: ", "Error");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Select tblUsers failed \n" + err.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }             

        }
        void frMenu_Disposed(object sender, EventArgs e)
        {
            loginID.Text = "";
            loginPassword.Text = "";
            loginMessage.Text = "";
            pictureBox1.ImageLocation = "";
            loginID.Enabled = true;
            loginPassword.Enabled = true;
            loginEnter.Visible = true;
            loginContinue.Visible = false;
            this.Show();
            this.Activate();
        }

        private void loginContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu frMenu = new FormMenu(dataConnection, isManager);
            frMenu.Show();
            frMenu.Disposed += new EventHandler(frMenu_Disposed);
        }
    }
}
