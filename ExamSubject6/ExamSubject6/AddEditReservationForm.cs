using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSubject6
{
    public partial class AddEditReservationForm : Form
    {
        private List<Room> rooms;
        public Reservation Reservation {  get; set; }
        public AddEditReservationForm(List<Room> _rooms)
        {
            InitializeComponent();
            rooms = _rooms;
            lbRooms.Items.AddRange(rooms.Select(s => s.Number.ToString()).ToArray());

            nudPersons.Validating += nudPersons_Validating;
            dtpCheckOut.Validating += dtpCheckOut_Validating;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                int id = (int)nudId.Value;
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                int persons = (int)nudPersons.Value;
                int roomId = rooms[lbRooms.SelectedIndex].Id;

                Reservation = new Reservation(id, checkIn, checkOut, persons, roomId);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void nudPersons_Validating(object sender, CancelEventArgs e)
        {
            if (lbRooms.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPersons, "Please select a room first");
                return;
            }

            if (nudPersons.Value > rooms[lbRooms.SelectedIndex].Beds) 
            {
                e.Cancel = true;
                errorProvider1.SetError(nudPersons, "No of persons cannot be greater than no of beds");
            }
        }

        private void dtpCheckOut_Validating(object sender, CancelEventArgs e)
        {
            if(dtpCheckIn.Value > dtpCheckOut.Value)
            {
                e.Cancel = true;
                errorProvider1.SetError(dtpCheckOut, "Check out cannot be before check in");
            }
        }
    }
}
