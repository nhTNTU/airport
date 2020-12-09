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

namespace Schedule
{
    public partial class EditFlightForm : Form
    {
        public Flight Flight = new Flight();
        public enum Action { Insert, Update };
        public Action act;

        private bool _error = false;
        private bool _loaded = false;


        public EditFlightForm()
        {
            InitializeComponent();
        }

        private void EditFlightForm_Load(object sender, EventArgs e)
        {
            //для всіх
            PlaneList _PlaneList = PlaneList.GetRefPlanesList();
            planecomboBox.DataSource = _PlaneList;
            planecomboBox.DisplayMember = "PlaneNumber";
            planecomboBox.ValueMember = "PlaneID";

            AircompaniesList _AircompaniesList = AircompaniesList.GetRefAircompaniesList();
            aircompanycomboBox.DataSource = _AircompaniesList;
            aircompanycomboBox.DisplayMember = "AirCompanyName";
            aircompanycomboBox.ValueMember = "AirCompanyID";

            if (act == Action.Insert)
            {
                //для вставки
                CountriesList _countriesList = CountriesList.GetRefCountriesList();
                countrycomboBox.DataSource = _countriesList;
                countrycomboBox.DisplayMember = "CountryName";
                countrycomboBox.ValueMember = "CountryID";

                int _selectedCountry = (int)countrycomboBox.SelectedValue;

                CitiesList _citiesList = CitiesList.GetCitiesListByCountry(_selectedCountry);
                citycomboBox.DataSource = _citiesList;
                citycomboBox.DisplayMember = "CityName";
                citycomboBox.ValueMember = "CityID";

                int _selectedCity = (int)citycomboBox.SelectedValue;

                AirPortList _airportList = AirPortList.GetRefAirportListByCity(_selectedCity);
                airportcomboBox.DataSource = _airportList;
                airportcomboBox.DisplayMember = "AirportName";
                airportcomboBox.ValueMember = "AirportID";

                flightTypecomboBox.SelectedIndex = 0;

                _loaded = true;
            }

            if (act == Action.Update)
            {
                //для оновлення
                try
                {
                    aircompanycomboBox.SelectedValue = Flight.FlightAircompanyID;
                    planecomboBox.SelectedValue = Flight.FlightPlaneID;

                    AirPort _apinfo = new AirPort();
                    _apinfo.GetAirport(Flight.FlightAirPortID);
                    City _City = new City();
                    _City.GetCity(_apinfo.AirPortCityID);

                    CountriesList _countriesList = CountriesList.GetRefCountriesList();
                    countrycomboBox.DataSource = _countriesList;
                    countrycomboBox.DisplayMember = "CountryName";
                    countrycomboBox.ValueMember = "CountryID";
                    countrycomboBox.SelectedValue = _City.CountryID;

                    CitiesList _citiesList = CitiesList.GetCitiesListByCountry(_City.CountryID);
                    citycomboBox.DataSource = _citiesList;
                    citycomboBox.DisplayMember = "CityName";
                    citycomboBox.ValueMember = "CityID";
                    citycomboBox.SelectedValue = _apinfo.AirPortCityID;

                    AirPortList _airportList = AirPortList.GetRefAirportListByCity(_apinfo.AirPortCityID);
                    airportcomboBox.DataSource = _airportList;
                    airportcomboBox.DisplayMember = "AirportName";
                    airportcomboBox.ValueMember = "AirportID";
                    airportcomboBox.SelectedValue = _apinfo.AirPortID;

                    if (Flight.FlightType == "Вхідний")
                        flightTypecomboBox.SelectedIndex = 0;
                    else if (Flight.FlightType == "Вихідний")
                        flightTypecomboBox.SelectedIndex = 1;

                    startdateTimePicker.Value = Flight.FlightDateTimeStart;
                    DateTime _tempDuration = Convert.ToDateTime("1900-01-01 " + Flight.FlightDuration);
                    economnumericUpDown.Value = Flight.FlightPriceEconom;
                    businessnumericUpDown.Value = Flight.FlightPriceBusiness;
                    firstnumericUpDown.Value = Flight.FlightPriceFirst;

                    numOfFlishgslabel.Visible = false;
                    periodicitylabel.Visible = false;

                    numOfFlightsnumericUpDown.Visible = false;
                    periodicitydateTimePicker.Visible = false;

                    if (Config.HasUserAccess("UpdateFlight"))
                        okButton.Visible = true;
                    else
                        okButton.Visible = false;

                    _loaded = true;
                }
                catch (Exception)
                {
                    _error = true;
                }
            }
        }

        private void EditFlightForm_Shown(object sender, EventArgs e)
        {
            if (_error == true)
            {
                MessageBox.Show("виникла непередбачувана помилка, неможливо відкрити дані.", "Oooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            _loaded = true;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (economnumericUpDown.Value < 1000 || businessnumericUpDown.Value < 1000 || firstnumericUpDown.Value < 1000)
            {
                MessageBox.Show("Не вигідно робити таку низьку ціну за рейс.", "Як же я хочу спати!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if ((int)airportcomboBox.SelectedValue == 1)
                    {
                        MessageBox.Show("Не можна вибрати свій аеропорт.", "Як же я хочу спати!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Flight.FlightAircompanyID = (int)aircompanycomboBox.SelectedValue;
                        Flight.FlightAirPortID = (int)airportcomboBox.SelectedValue;
                        Flight.FlightPlaneID = (int)planecomboBox.SelectedValue;
                        if (flightTypecomboBox.SelectedIndex == 0)
                            Flight.FlightType = "Вхідний";
                        else if (flightTypecomboBox.SelectedIndex == 1)
                            Flight.FlightType = "Вихідний";
                        Flight.FlightDateTimeStart = startdateTimePicker.Value;
                        Flight.FlightDateTimeStart.AddSeconds((-1) * Flight.FlightDateTimeStart.Second);
                        string _tempDuration = "";
                        if (durationdateTimePicker.Value.Hour < 10)
                            _tempDuration += "0";
                        _tempDuration += durationdateTimePicker.Value.Hour.ToString() + ":";
                        _tempDuration += durationdateTimePicker.Value.Minute.ToString() + ":00";
                        Flight.FlightNumOfFlights = (int)numOfFlightsnumericUpDown.Value;

                        string _tempPeriodicity = "1900-01-";
                        if (periodicitydateTimePicker.Value.Day < 10)
                            _tempPeriodicity += "0";
                        _tempPeriodicity += periodicitydateTimePicker.Value.Day.ToString() + " ";
                        if (periodicitydateTimePicker.Value.Hour < 10)
                            _tempPeriodicity += "0";
                        _tempPeriodicity += periodicitydateTimePicker.Value.Hour.ToString() + ":";
                        if (periodicitydateTimePicker.Value.Minute < 10)
                            _tempPeriodicity += "0";
                        _tempPeriodicity += periodicitydateTimePicker.Value.Minute.ToString() + ":00";
                        Flight.FlightDuration = _tempDuration;
                        Flight.FlightPeriodicity = Convert.ToDateTime(_tempPeriodicity);
                        Flight.FlightPriceEconom = economnumericUpDown.Value;
                        Flight.FlightPriceBusiness = businessnumericUpDown.Value;
                        Flight.FlightPriceFirst = firstnumericUpDown.Value;

                        if (act == Action.Insert)
                        {
                            Flight.InsertFlight();
                        }
                        else if (act == Action.Update)
                        {
                            Flight.EditFlight();
                        }
                        if (Flight.e == null)
                        {
                            this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        }
                        else if (Flight.e != null)
                        {
                            MessageBox.Show("Помилка при добавленні чи створенні рейсу.", "Oooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex is NullReferenceException)
                    {
                        MessageBox.Show("Помилка. Перевірте, чи всі дані заповненні.", "Oooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex is DataException)
                    {
                        MessageBox.Show("Помилка в базі даних.", "Oooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Невідома науці помилка.", "Oooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }//end of checks
        }

        private void countrycomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_loaded == true)
            {
                int _selectedCountry = (int)countrycomboBox.SelectedValue;

                CitiesList _citiesList = CitiesList.GetCitiesListByCountry(_selectedCountry);
                //citycomboBox.DataSource = null;
                
                citycomboBox.DisplayMember = "CityName";
                citycomboBox.ValueMember = "CityID";
                citycomboBox.DataSource = _citiesList;
            }
        }

        private void citycomboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_loaded == true)
            {
                int _selectedCity = (int)citycomboBox.SelectedValue;

                AirPortList _airportList = AirPortList.GetRefAirportListByCity(_selectedCity);
                //airportcomboBox.DataSource = null;
                
                airportcomboBox.DisplayMember = "AirportName";
                airportcomboBox.ValueMember = "AirportID";
                airportcomboBox.DataSource = _airportList;
            }
        }
    }
}
