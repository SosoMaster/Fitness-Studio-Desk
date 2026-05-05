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
        public BookingForm()
        {
            InitializeComponent();
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
            Booking booking = new Booking();
           
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
