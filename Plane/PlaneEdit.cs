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
    public partial class PlaneEdit : Form
    {
        public PlaneEdit()
        {
            InitializeComponent();
        }

        public enum Action
        {
            Insert, Update
        }

        public AirportLib.Plane plane = new AirportLib.Plane();

        public Action act;

        private void PlaneEdit_Load(object sender, EventArgs e)
        {
            AircompaniesList _aclist = AircompaniesList.GetRefAircompaniesList();
            if (_aclist.Count == 0)
            {
                MessageBox.Show("Ні одної авіакомпанії не знайдено. Добавте їх або зверніться до адміністратора.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {

                //airCompanycomboBox.SelectedValue = plane.PlaneAircompanyID;
                airCompanycomboBox.DataSource = _aclist;
               
                airCompanycomboBox.DisplayMember = "AircompanyName";
                airCompanycomboBox.ValueMember = "AircompanyID";
                
                planeNumberTextbox.Text = plane.PlaneNumber;
                modeltextBox.Text = plane.PlaneModel;
                if (act == Action.Update)
                {
                    airCompanycomboBox.SelectedValue = plane.PlaneAircompanyID;
                    if (Config.HasUserAccess("UpdatePlane"))
                        OKbutton.Visible = true;
                    else
                        OKbutton.Visible = false;
                }
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            plane.PlaneAircompanyID = (int)airCompanycomboBox.SelectedValue;
            plane.PlaneModel = modeltextBox.Text;
            plane.PlaneNumber = planeNumberTextbox.Text;
            if (act == Action.Insert)
            {
                plane.InsertPlane();
            }
            else if (act == Action.Update)
            {
                plane.UpdatePlane();
            }

            if (plane.e != null)
            {
                MessageBox.Show("Неможливо знайти або одновити інформацію про літак.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                plane.e = null;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }


        }
    }
}
