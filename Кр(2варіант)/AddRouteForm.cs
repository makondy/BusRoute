using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Кр_2варіант_
{
    public partial class AddRouteForm : Form
    {
        public BusRoute NewRoute { get; private set; }

        public AddRouteForm()
        {
            InitializeComponent();
        }

        public AddRouteForm(BusRoute route) : this()
        {
            // Заповнення полів для редагування
            txtRouteNumber.Text = route.RouteNumber.ToString();
            txtDestination.Text = route.Destination;
            cmbStops.Items.AddRange(route.Stops);
            dtpDepartureTime.Value = route.DepartureTime;
            txtSeatsAvailable.Text = route.SeatsAvailable.ToString();
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Зчитування даних з полів
            int routeNumber = int.Parse(txtRouteNumber.Text);
            string destination = txtDestination.Text;
            string[] stops = cmbStops.Text.Split(',');
            DateTime departureTime = dtpDepartureTime.Value;
            int seatsAvailable = int.Parse(txtSeatsAvailable.Text);


            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpDepartureTime_ValueChanged(object sender, EventArgs e)
        {
            dtpDepartureTime.Format = DateTimePickerFormat.Custom;
            dtpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";

        }
    }

}
