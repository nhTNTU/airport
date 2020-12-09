using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AirportLib;

namespace Aircompanies
{
    public partial class AirCompaniesForm : Form
    {
        AircompaniesList acList = new AircompaniesList();
        public AirCompaniesForm()
        {
            InitializeComponent();
        }

        void RefreshItems()
        {
            acList = AircompaniesList.GetDefaultAircompaniesList();
            aircompaniesListBindingSource.DataSource = null;
            aircompaniesListBindingSource.DataSource = acList;

            if (Config.HasUserAccess("AircompanyInsert"))
                buttonAdd.Visible = true;
            else
                buttonAdd.Visible = false;

            if (Config.HasUserAccess("AircompanyDelete"))
                buttonDelete.Visible = true;
            else
                buttonDelete.Visible = false;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            this.RefreshItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AirCompaniesEditForm newForm = new AirCompaniesEditForm();

            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.newAirсompany.InsertNewAircompany();
            }
            this.RefreshItems();
        }

        private void AirCompaniesForm_Load(object sender, EventArgs e)
        {
            this.RefreshItems();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int airCompID = (int)aircompaniesListDataGridView.SelectedRows[0].Cells[0].Value;

            AirCompaniesEditForm newForm = new AirCompaniesEditForm();
            foreach (Aircompany aircompany in acList)
            {
                if (aircompany.AircompanyID == airCompID)
                {
                    newForm.newAirсompany = aircompany;
                    if (newForm.ShowDialog() == DialogResult.OK)
                    {
                        newForm.newAirсompany.UpdateAircompany();
                    }
                }
            }
            this.RefreshItems();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int airCompID = (int)aircompaniesListDataGridView.SelectedRows[0].Cells[0].Value;

            foreach (Aircompany aircompany in acList)
            {
                if (aircompany.AircompanyID == airCompID)
                {
                    aircompany.DeleteAircompany();
                }
            }
            this.RefreshItems();
        }
    }
}
