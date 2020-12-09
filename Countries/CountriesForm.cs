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
    public partial class CountriesForm : Form
    {
        CountriesList cList = new CountriesList();

        public CountriesForm()
        {
            InitializeComponent();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        void RefreshItems()
        {
            cList = CountriesList.GetDefaultCountriesList();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cList;

            if (Config.HasUserAccess("CountryInsert"))
                buttonAdd.Visible = true;
            else
                buttonAdd.Visible = false;

            if (Config.HasUserAccess("GetCountry"))
                buttonEdit.Visible = true;
            else
                buttonEdit.Visible = false;

            if (Config.HasUserAccess("CountryDelete"))
                buttonDelete.Visible = true;
            else
                buttonDelete.Visible = false;
        }

        private void CountriesForm_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CountriesEditForm newForm = new CountriesEditForm();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                newForm.сountry.InsertNewCountry();
            }
            RefreshItems();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                int _countryID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

                CountriesEditForm newForm = new CountriesEditForm();
                foreach (Country cInfo in cList)
                {
                    if (cInfo.CountryID == _countryID)
                    {
                        cInfo.GetCountry(_countryID);
                        newForm.сountry = cInfo;
                        if (newForm.ShowDialog() == DialogResult.OK)
                        {
                            newForm.сountry.UpdateCountry();
                        }
                    }
                }
                RefreshItems();
            }
            else
            {
                MessageBox.Show("Елемнти відсутні або не вибрані", "Елемент не вибраний", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int _countryID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            foreach (Country cInfo in cList)
            {
                if (cInfo.CountryID == _countryID)
                {
                    cInfo.GetCountry(_countryID);
                    cInfo.DeleteCountry();
                }
            }
            RefreshItems();
        }
    }
}
