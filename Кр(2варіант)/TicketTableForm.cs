using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Кр_2варіант_;

namespace Кр_2варіант_
{

    public partial class TicketTableForm : Form
    {
        private int _routeNumber;
        private List<Ticket> _tickets;

        public TicketTableForm(int routeNumber)
        {
            InitializeComponent();
            _routeNumber = routeNumber;
            _tickets = new List<Ticket>(); // Список квитків

            // Відображення номеру рейсу
            lblRouteNumber.Text = $"Рейс: {_routeNumber}";
        }

        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            // Відкриття форми для додавання нового квитка
            using (var ticketForm = new TicketForm(_routeNumber))
            {
                if (ticketForm.ShowDialog() == DialogResult.OK)
                {
                    Ticket newTicket = ticketForm.CreatedTicket;
                    _tickets.Add(newTicket);

                    // Додавання нового квитка до таблиці
                    dgvTickets.Rows.Add(newTicket.PassengerName, newTicket.PassengerLastName, newTicket.BenefitDescription);
                }
            }
        }
        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Можливо, додати код для обробки кліків по комірках таблиці
        }
    }

}
