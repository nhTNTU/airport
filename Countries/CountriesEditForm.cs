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

namespace Countries
{
    public partial class CountriesEditForm : Form
    {
        public Country сountry = new Country();
        public CountriesEditForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            сountry.CountryName = countryNameTextBox.Text;
        }

        private void CountriesEditForm_Load(object sender, EventArgs e)
        {
            countryNameTextBox.Text = сountry.CountryName;
            if (сountry.CountryID > 0)
            {
                if (Config.HasUserAccess("CountryDelete"))
                    buttonOK.Visible = true;
                else
                    buttonOK.Visible = false;
            }
        }
    }
}
