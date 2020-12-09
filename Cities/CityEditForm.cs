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

namespace Cities
{
    public partial class CityEditForm : Form
    {
        public City City = new City();
        public CityEditForm()
        {
            InitializeComponent();
        }

        private void CityEditForm_Load(object sender, EventArgs e)
        {
            CountriesList _countriesList = CountriesList.GetDefaultCountriesList();
            countryIDcomboBox.DataSource = _countriesList;

            countryIDcomboBox.SelectedValue = City.CountryID;
            cityNameTextBox.Text = City.CityName;
            if (City.CitySignGMT == "+")
                comboBox1.SelectedIndex = 0;
            else if (City.CitySignGMT == "-")
                comboBox1.SelectedIndex = 1;
            populationTextBox.Text = City.CityPopulation.ToString();
            cityNameTextBox.Text = City.CityName;
            gMTDateTimePicker.Value = City.CityGMT;

            if (City.CityID > 0)
            {
                if (Config.HasUserAccess("CityUpdate"))
                    buttonOk.Visible = true;
                else
                    buttonOk.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            bool flag = true;
            DateTime _pickerGmt = gMTDateTimePicker.Value;
            DateTime _gmt = new DateTime(1900, 1, 1, _pickerGmt.Hour, _pickerGmt.Minute, 0);
            if (comboBox1.SelectedIndex == 0)
                City.CitySignGMT = "+";
            else if (comboBox1.SelectedIndex == 1)
                City.CitySignGMT = "-";
            if (IsPopulationLong(populationTextBox.Text) == false)
            {
                MessageBox.Show("Населення повинне бути числом!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (_pickerGmt.Hour > 12 || (_pickerGmt.Hour == 12 && _pickerGmt.Minute > 0))
            {
                MessageBox.Show("Значення часового поясу не може бути більше 12 годин.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                City.CityName = cityNameTextBox.Text;
                City.CountryID = (int)countryIDcomboBox.SelectedValue;
                City.CityGMT = _gmt;
                City.CityPopulation = Convert.ToInt64(populationTextBox.Text);
                int selectedCountryID;

                try
                {
                    selectedCountryID = (int)countryIDcomboBox.SelectedValue;
                }
                catch (NullReferenceException ex)
                {
                    flag = false;
                    MessageBox.Show(ex.Message + " Вкажіть правильно країну.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (flag == true)
                {
                    City.CountryID = (int)countryIDcomboBox.SelectedValue;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }

        //check if population is long
        private bool IsPopulationLong(object pop)
        {
            try
            {
                Convert.ToUInt64(pop);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
