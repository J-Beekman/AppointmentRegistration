using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using AppointmentRegistration.Forms;

namespace AppointmentRegistration
{ 
    public partial class MainScreen : Form
    {
        private string operation = "";
        public MainScreen()
        {
            InitializeComponent();
        }

        private void hideTopButtons()
        {
            createButton.Visible = false;
            readButton.Visible = false;
            updateButton.Visible = false;
            deleteButton.Visible = false;
            patientButton.Visible = true;
            doctorButton.Visible = true;
            nurseButton.Visible = true;
            appointmentButton.Visible = true;
            scheduleButton.Visible = true;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            operation = "create";
            hideTopButtons();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            operation = "read";
            hideTopButtons();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            operation = "update";
            hideTopButtons();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            operation = "delete";
            hideTopButtons();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            PatientForm patientForm = new PatientForm(operation);
            patientForm.Show();
            this.Hide();
        }

        private void doctorButton_Click(object sender, EventArgs e)
        {

        }

        private void nurseButton_Click(object sender, EventArgs e)
        {

        }

        private void appointmentButton_Click(object sender, EventArgs e)
        {

        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {

        }
    }
}
