using FitnessStudioApp.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitnessStudioApp.FORMS
{
    public partial class BookingForm : Form
    {
        private int currentClientId;

        public BookingForm(int clientId)
        {
            InitializeComponent();
            currentClientId = clientId;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            // get data from dropdown trainer
            // get data from dropdown tr_type
            // get data from calendar
            // create new booking obj
            // save booking obj to db.
            // edit trainers availability
            // 
            if (cmb_TrainingSession.SelectedIndex == -1)
            {
                MessageBox.Show("Моля, изберете тренировка!");
                return;
            }

            int trainingSessionId = (int)cmb_TrainingSession.SelectedValue;

            Booking booking = new Booking()
            {
                ClientId = currentClientId,
                TrainingSessionId = trainingSessionId,
                BookingDate = DateTime.Now,
                Status = "Active"
            };

            await _bookingRepository.AddAsync(booking);

            MessageBox.Show("Успешна резервация!");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }

        private void cmb_TrainingType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Trainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
