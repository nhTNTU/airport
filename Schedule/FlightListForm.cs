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
    public partial class FlightListForm : Form
    {
        public FlightListForm()
        {
            InitializeComponent();
        }

        private void FlightListForm_Load(object sender, EventArgs e)
        {
            /*FlightListControl flControl = new FlightListControl();
        flControl.Location = new Point(0, 0);
        Size sz = new System.Drawing.Size();
        sz.Width = this.Width;
        sz.Height = this.Height;
        sz.Height = sz.Height - 100;
        flControl.Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
        flControl.Size = sz;
        this.Controls.Add(flControl);*/

            if (Config.HasUserAccess("GetFlight"))
                editButton.Visible = true;
            else
                editButton.Visible = false;

            if (Config.HasUserAccess("InsertFlight"))
                addButton.Visible = true;
            else
                addButton.Visible = false;

            if (Config.HasUserAccess("DeleteFlight"))
                deleteButton.Visible = true;
            else
                deleteButton.Visible = false;
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            EditFlightForm myForm = new EditFlightForm();
            myForm.act = EditFlightForm.Action.Insert;
            if (myForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                flightListControl1.ReloadFlightList();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (flightListControl1.SelectedFlight > 0)
            {
                EditFlightForm myForm = new EditFlightForm();
                myForm.act = EditFlightForm.Action.Update;
                myForm.Flight.GetFlight(flightListControl1.SelectedFlight);
                if (myForm.Flight.e == null)
                {
                    if (myForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        flightListControl1.ReloadFlightList();
                }
                else if (myForm.Flight.e != null)
                {
                    MessageBox.Show("Неможливо відредагувати даний запис", "Ooooppps!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (flightListControl1.SelectedFlight == 0)
            {
                MessageBox.Show("Виберіть рейс.", "Ooooppps!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (flightListControl1.SelectedFlight > 0)
            {
                Flight fi = new Flight();
                fi.FlightID = flightListControl1.SelectedFlight;
                DialogResult result = MessageBox.Show("Ви дійсно хочете видалити цей рейс?", "Ви впевнені?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    fi.DeleteFlight();
                    if (fi.e == null)
                    {
                        MessageBox.Show("Рейс успішно вилучено!", "Яке щастя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        flightListControl1.ReloadFlightList();
                    }
                    else if (fi.e != null)
                    {
                        if (fi.e.ErrorCode == 547)
                            MessageBox.Show("З обраним рейсом пов'язані інші дані. Видалення неможливо.", "Печаль біда.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            MessageBox.Show("Невідома помилка. Видалення неможливо.", "Печаль біда.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (flightListControl1.SelectedFlight == 0)
            {
                MessageBox.Show("Виберіть рейс.", "Ooooppps!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
