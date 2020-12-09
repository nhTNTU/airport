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

namespace AirPortS
{
    public partial class AirPortEditForm : Form
    {
        public AirPort airport = new AirPort();
        public enum Action
        {
            insert, update
        }

        public AirPortEditForm()
        {
            InitializeComponent();
        }

        public Action act = new Action();

        private void AirPortEditForm_Load(object sender, EventArgs e)
        {
            CountriesList _countries = CountriesList.GetDefaultCountriesList();
            countryComboBox.DataSource = _countries;
            countryComboBox.DisplayMember = "CountryName";
            countryComboBox.ValueMember = "CountryID";

            //якщо кількість країн рівна нулю
            if (_countries.Count == 0)
            {
                DialogResult di = MessageBox.Show("Список країн пустий, операція неможлива. Зверніться до адміністратора для вирішення даної проблеми.", "Операція неможлива", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (di == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
            //Якщо є інші країни
            else if (_countries.Count > 0)
            {
                /*int countryID = (int)countryComboBox.SelectedValue;
				CitiesList _cities = CitiesList.GetCitiesListByCountry(countryID);
				CityComboBox.DataSource = _cities;
				CityComboBox.DisplayMember = "CityName";
				CityComboBox.ValueMember = "CityID";
				*/

                //для вставки

                //для оновлення
                if (act == Action.update)
                {
                    //місто і країна в яких знаходиться аеропорт
                    Country country = new Country();
                    City city = new City();
                    city.GetCity(airport.AirPortCityID);
                    country.GetCountry(city.CountryID);
                    int _selectedCountryID = country.CountryID;
                    int _selectedCityID = city.CityID;

                    //Заповняємо комбобокс містами
                    CitiesList _cities = CitiesList.GetCitiesListByCountry(_selectedCountryID);
                    CityComboBox.DataSource = _cities;
                    CityComboBox.DisplayMember = "CityName";
                    CityComboBox.ValueMember = "CityID";


                    countryComboBox.SelectedValue = _selectedCountryID;
                    CityComboBox.SelectedValue = _selectedCityID;
                    airPortNameTextBox.Text = airport.AirPortName;

                    if (Config.HasUserAccess("UpdateAirport"))
                        OKbutton.Visible = true;
                    else
                        OKbutton.Visible = false;
                }
                else if (act == Action.insert)
                {

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CitiesList cl = CitiesList.GetCitiesListByCountry((int)countryComboBox.SelectedValue);
            CityComboBox.DataSource = cl;
            CityComboBox.DisplayMember = "CityName";
            CityComboBox.ValueMember = "CityID";
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            CitiesList _cl = (CitiesList)CityComboBox.DataSource;
            if (_cl.Count == 0)
                MessageBox.Show("У вказаній країні не вказано міст. Виберіть іншу країну.", "Не вибране місто", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (_cl.Count != 0)
            {
                airport.AirPortName = airPortNameTextBox.Text;
                airport.AirPortCityID= (int)CityComboBox.SelectedValue;
                if (act == Action.update)
                {
                    airport.UpdateAirport();
                }
                else if (act == Action.insert)
                    airport.InsertAirport();
                if (airport.e != null)
                {
                    MessageBox.Show("Внутрішня помилка, дані не можуть бути оновленні по невідомій причині. При повторній появі помилки зверніться до адміністратора.", "Невідома помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }

            }
        }
    }
}
