using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Кр_2варіант_
{
    public partial class TicketForm : Form
    {

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rbHasBenefit_CheckedChanged(object sender, EventArgs e)
        {
            // Увімкнення/вимкнення поля для пільг
            txtBenefit.Enabled = rbYes.Checked;
        }
    }
}
