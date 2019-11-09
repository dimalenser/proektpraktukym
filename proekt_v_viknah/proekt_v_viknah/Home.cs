using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_v_viknah
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonGoToRegistration_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Hide();
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            Rating rt = new Rating();
            rt.Show();
            Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
