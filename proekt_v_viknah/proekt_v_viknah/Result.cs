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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            Rating rt = new Rating();
            rt.Show();
            Hide();
        }
    }
}
