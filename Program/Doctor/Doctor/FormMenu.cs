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
    public partial class FormMenu : Form
    {
        private OleDbConnection dataConnection;
        private bool isManager;
        public FormMenu(OleDbConnection dataConnection, bool isManager)
        {
            InitializeComponent();
            this.dataConnection = dataConnection;
            this.isManager = isManager;
            if (!isManager)
                tblUsers.Enabled = false;
        }

        void Form_Disposed(object sender, EventArgs e)
        {
            this.Show();
            this.Activate();
        }

        

        private void tblUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblUsers frm = new FormTblUsers(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatients frm = new FormTblPatients(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }


        private void tblVisits_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblVisits frm = new FormTblVisits(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblOperations frm = new FormTblOperations(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblTreats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblTreats frm = new FormTblTreats(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblDrugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblDrugs frm = new FormTblDrugs(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblVaccines_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblVaccines frm = new FormTblVaccines(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblDiseases_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblDiseases frm = new FormTblDiseases(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatientOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatientOperations frm = new FormTblPatientOperations(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatientTreats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatientTreats frm = new FormTblPatientTreats(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatientDrugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatientDrugs frm = new FormTblPatientDrugs(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatientVaccines_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatientVaccines frm = new FormTblPatientVaccines(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblPatientDiseases_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblPatientDiseases frm = new FormTblPatientDiseases(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblCities_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblCities frm = new FormTblCities(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void tblRoles_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTblRoles frm = new FormTblRoles(isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatient frm = new FormAddPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddUser frm = new FormAddUser(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addVisit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddVisit frm = new FormAddVisit(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addOperation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddOperation frm = new FormAddOperation(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addTreat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddTreat frm = new FormAddTreat(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addDrug_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddDrug frm = new FormAddDrug(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addVaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddVaccine frm = new FormAddVaccine(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addDisease_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddDisease frm = new FormAddDisease(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatOperation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatiOperation frm = new FormAddPatiOperation(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatTreat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatiTreat frm = new FormAddPatiTreat(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatDrug_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatiDrug frm = new FormAddPatiDrug(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatVaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatiVaccine frm = new FormAddPatiVaccine(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addPatDisease_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddPatiDisease frm = new FormAddPatiDisease(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }
        
        private void addCity_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddCity frm = new FormAddCity(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void addRole_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddRole frm = new FormAddRole(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateUser frm = new FormUpdateUser(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatient frm = new FormUpdatePatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateVisit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateVisits frm = new FormUpdateVisits(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateOpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateOperation frm = new FormUpdateOperation(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateTrt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateTreats frm = new FormUpdateTreats(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateDrg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateDrug frm = new FormUpdateDrug(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateVaccine frm = new FormUpdateVaccine(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updateDss_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateDisease frm = new FormUpdateDisease(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePtiOpr_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatiOperation frm = new FormUpdatePatiOperation(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePtiTrt_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatiTreat frm = new FormUpdatePatiTreat(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePtiDrg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatiDrug frm = new FormUpdatePatiDrug(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePtiVac_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatiVaccine frm = new FormUpdatePatiVaccine(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void updatePtiDss_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdatePatiDisease frm = new FormUpdatePatiDisease(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptVisitsOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptVisitsOfPatient frm = new FormRptVisitsOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptOperationsOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptOperationsOfPatient frm = new FormRptOperationsOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptTreatsOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptTreatsOfPatient frm = new FormRptTreatsOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptDrugsOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDrugsOfPatient frm = new FormRptDrugsOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptVaccinesOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptVaccinesOfPatient frm = new FormRptVaccinesOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptDiseasesOfPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDiseasesOfPatient frm = new FormRptDiseasesOfPatient(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptPatientsWithOperation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsWithOperation frm = new FormRptPatientsWithOperation(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptPatientsWithTreat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsWithTreat frm = new FormRptPatientsWithTreat(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptPatientsWithDrug_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsWithDrug frm = new FormRptPatientsWithDrug(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptPatientsWithVaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsWithVaccine frm = new FormRptPatientsWithVaccine(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptPatientsWithDisease_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptPatientsWithDisease frm = new FormRptPatientsWithDisease(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptVisitsByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptVisitsByDate frm = new FormRptVisitsByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptOperationsByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptOperationsByDate frm = new FormRptOperationsByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptTreatsByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptTreatsByDate frm = new FormRptTreatsByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptDrugsByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDrugsByDate frm = new FormRptDrugsByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptVaccinesByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptVaccinesByDate frm = new FormRptVaccinesByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormRptDiseasesByDate_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRptDiseasesByDate frm = new FormRptDiseasesByDate(dataConnection, isManager);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndOperations_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndOperations frm = new FormChartPatientAndOperations(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndTreats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndTreats frm = new FormChartPatientAndTreats(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndDrugs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndDrugs frm = new FormChartPatientAndDrugs(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndVaccinnes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndTreats frm = new FormChartPatientAndTreats(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndVaccines(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndTreats frm = new FormChartPatientAndTreats(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndDiseases_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndTreats frm = new FormChartPatientAndTreats(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndVaccines_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndTreats frm = new FormChartPatientAndTreats(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }

        private void FormChartPatientAndVaccine_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormChartPatientAndVaccines frm = new FormChartPatientAndVaccines(dataConnection);
            frm.Show();
            frm.Disposed += new EventHandler(Form_Disposed);
        }
       
    }
}

