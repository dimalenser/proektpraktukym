using System;
using System.IO;
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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Close();
        }

        private void buttonGoToTest_Click(object sender, EventArgs e)
        {
            Program.pib = Convert.ToString(textBoxPIB.Text);
            Program.grupa = Convert.ToString(textBoxGrupa.Text);

            Question1 qstn = new Question1();
            qstn.Show();
            Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
