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

namespace Plane
{
    public partial class PlanesForm : Form
    {
        public PlanesForm()
        {
            InitializeComponent();
        }

        private void PlanesForm_Load(object sender, EventArgs e)
        {
            RefreshItems();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
        }

        void RefreshItems()
        {
            PlaneList _plist = PlaneList.GetDefaultPlanesList();
            if (_plist == null)
            {
                MessageBox.Show("Виникла помилка при підключенні до БД.", "Внутрішня помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = _plist;
                //dataGridView1.AllowUserToOrderColumns = true;
                if (_plist.Count == 0)
                {
                    editButton.Visible = false;
                    deleteButton.Visible = false;
                }
                else
                {
                    editButton.Visible = true;
                    deleteButton.Visible = true;

                    if (Config.HasUserAccess("GetPlane"))
                        editButton.Visible = true;
                    else
                        editButton.Visible = false;

                    if (Config.HasUserAccess("DeletePlane"))
                        deleteButton.Visible = true;
                    else
                        deleteButton.Visible = false;

                }
                if (Config.HasUserAccess("InsertPlane"))
                    addButton.Visible = true;
                else
                    addButton.Visible = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PlaneEdit myForm = new PlaneEdit();
            myForm.act = PlaneEdit.Action.Insert;
            DialogResult result = myForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                RefreshItems();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int _selectedID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            PlaneEdit myForm = new PlaneEdit();
            myForm.act = PlaneEdit.Action.Update;
            myForm.plane.GetPlane(_selectedID);
            DialogResult result = myForm.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                RefreshItems();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int _selectedID = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("Ви дійсно хочете видалити даний запис про літак?", "Підтвердіть видалення", MessageBoxButtons.OKCancel);
            AirportLib.Plane plane = new AirportLib.Plane();
            plane.PlaneID = _selectedID;
            plane.DeletePlane();
            if (plane.e != null)
            {
                string errormsg = "";
                if (plane.e.ErrorCode == 547)
                {
                    errormsg = "З даним літаком пов'язані рейси. Видалити неможливо";
                }
                else
                {
                    errormsg = "Невідома помилка, операція не завершена через невідому причину";
                }
                MessageBox.Show(errormsg, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Операія виконана успішно", "Видалення завершене", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                RefreshItems();
            }
        }
    }
}
