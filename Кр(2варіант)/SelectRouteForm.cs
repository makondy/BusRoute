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
    public partial class SelectRouteForm : Form
    {
        // Властивість для збереження вибраного рейсу
        public string SelectedRoute { get; private set; }
        public SelectRouteForm()
        {
            InitializeComponent();
        }

        public SelectRouteForm(List<string> routes)
        {
            InitializeComponent();

            // Приклад: заповнення ComboBox списком рейсів
            comboBoxRoutes.Items.AddRange(routes.ToArray()); 
        }

        // Обробник кнопки "ОК"
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxRoutes.SelectedItem != null)
            {
                SelectedRoute = comboBoxRoutes.SelectedItem.ToString();
                this.DialogResult = DialogResult.OK; // Закриваємо форму з підтвердженням
            }
            else
            {
                MessageBox.Show("Будь ласка, оберіть рейс!", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Обробник кнопки "Скасувати"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Закриваємо форму без підтвердження
        }

        private void comboBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
