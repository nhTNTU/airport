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
    public partial class CitiesForm : Form
    {
        CitiesList _cList = new CitiesList();
        public CitiesForm()
        {
            InitializeComponent();
        }

        void RefreshItems()
        {
            _cList = CitiesList.GetDefaultCitiesList();
            citiesListDataGridView.DataSource = null;
            citiesListDataGridView.DataSource = _cList;

            if (Config.HasUserAccess("CityInsert"))
                buttonAdd.Visible = true;
            else
                buttonAdd.Visible = false;

            if (Config.HasUserAccess("GetCity"))
                buttonEdit.Visible = true;
            else
                buttonEdit.Visible = false;

            if (Config.HasUserAccess("CityDelete"))
                buttonDelete.Visible = true;
            else
                buttonDelete.Visible = false;
        }

        private void CitiesForm_Load(object sender, EventArgs e)
        {
            RefreshItems();
            citiesListDataGridView.AutoResizeColumns();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            CityEditForm myform = new CityEditForm();
            int selectedRow = (int)citiesListDataGridView.SelectedRows[0].Cells[0].Value;
            City ci = new City();
            ci.GetCity(selectedRow);
            myform.City = ci;
            myform.Text += ci.CityName;
            if (myform.ShowDialog() == DialogResult.OK)
            {
                myform.City.UpdateCity();
                if (myform.City.e != null)
                {
                    MessageBox.Show(myform.City.e.Message, "Транзакція не виконана", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                RefreshItems();
            }
        }

        private void citiesListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CityEditForm myform = new CityEditForm();
            myform.Text += "Новый";
            if (myform.ShowDialog() == DialogResult.OK)
            {
                myform.City.InsertCity();
                if (myform.City.e != null)
                {
                    MessageBox.Show(myform.City.e.Message, "Місто не добавлене!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshItems();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити запис?", "Підтвердіть видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.OK)
            {
                int _selectedRowID = (int)citiesListDataGridView.SelectedRows[0].Cells[0].Value;
                City city = new City();
                city.GetCity(_selectedRowID);
                city.DeleteCity();
                if (city.e != null)
                {
                    MessageBox.Show(city.e.Message, "Місто не було видалено!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            RefreshItems();
        }
    }
}
