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
    public partial class AirCompaniesEditForm : Form
    {
        public Aircompany newAirсompany = new Aircompany();

        public AirCompaniesEditForm()
        {
            InitializeComponent();
        }

        private void AirCompaniesEditForm_Load(object sender, EventArgs e)
        {
            this.Text += " - ";
            this.Text += airCompanyNameTextBox.Text;
            if (newAirсompany.AircompanyName.Equals(""))
            {
                this.Text += "Додати авіакомпанію";
            }
            else
            {
                this.Text += newAirсompany.AircompanyName;
            }
            airCompanyNameTextBox.Text = newAirсompany.AircompanyName;
            airCompanyPhoneTextBox.Text = newAirсompany.AircompanyPhone;
            airCompanyAddressTextBox.Text = newAirсompany.AircompanyAddress;
            if (newAirсompany.AircompanyID > 0)
            {
                if (Config.HasUserAccess("AircompanyUpdate"))
                    buttonOK.Visible = true;
                else
                    buttonOK.Visible = false;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            newAirсompany.AircompanyName = airCompanyNameTextBox.Text;
            newAirсompany.AircompanyPhone = airCompanyPhoneTextBox.Text;
            newAirсompany.AircompanyAddress = airCompanyAddressTextBox.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
