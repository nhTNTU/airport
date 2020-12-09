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
    public partial class AirPortsForm : Form
    {
        AirPortList myAirPortList = new AirPortList();
        public AirPortsForm()
        {
            InitializeComponent();
        }

        private void AirPortsForm_Load(object sender, EventArgs e)
        {
            RefreshItems();

        }

        private void RefreshItems()
        {
            myAirPortList = AirPortList.GetDefaultAirPortList();
            airPortListDataGridView.DataSource = null;
            airPortListDataGridView.DataSource = myAirPortList;
            if (myAirPortList.Count == 0)
            {
                EditButton.Visible = false;
                deleteButton.Visible = false;
            }
            else if (myAirPortList.Count > 0)
            {
                EditButton.Visible = true;
                deleteButton.Visible = true;

                if (Config.HasUserAccess("GetAirport"))
                    EditButton.Visible = true;
                else
                    EditButton.Visible = false;

                if (Config.HasUserAccess("DeleteAirport"))
                    deleteButton.Visible = true;
                else
                    deleteButton.Visible = false;
            }

            if (Config.HasUserAccess("InsertAirport"))
                addButton.Visible = true;
            else
                addButton.Visible = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            int selectedID = (int)airPortListDataGridView.SelectedRows[0].Cells[0].Value;
            AirPortEditForm myForm = new AirPortEditForm();
            myForm.act = AirPortEditForm.Action.update;
            myForm.airport.GetAirport(selectedID);
            DialogResult result = myForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                RefreshItems();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ви дійсно хочете видалити даний аеропорт?", "Підтвердіть видалення", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                int selectedID = (int)airPortListDataGridView.SelectedRows[0].Cells[0].Value;
                AirPort airport = new AirPort();
                airport.AirPortID = selectedID;
                airport.DeleteAirport();
                if (airport.e != null)
                {
                    //547
                    if (airport.e.ErrorCode == 547)
                    {
                        MessageBox.Show("Не можу видалити аеропорт. З вибранием аеропортом пов'язані інші дані.", "Помилка при виданені", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Неідома помилка, можливо сервер недоступний. Зверніться до адмінітратора.", "Помилка при виданені", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshItems();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AirPortEditForm myForm = new AirPortEditForm();
            myForm.act = AirPortEditForm.Action.insert;
            DialogResult result = myForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                RefreshItems();
        }

    }
}
