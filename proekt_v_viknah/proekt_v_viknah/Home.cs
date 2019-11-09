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

        private void Home_Load(object sender, EventArgs e)
        {
            /*var readnstudents = new System.IO.BinaryReader(
                              System.IO.File.OpenRead(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt"));
            int nstudents = readnstudents.ReadInt32();
            readnstudents.Close();
            label1.Text = nstudents.ToString();
            var writer2 = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt",
                              System.IO.FileMode.Create));
            nstudents = 6;
            writer2.Write(nstudents);
            writer2.Close();*/
        }
    }
}
