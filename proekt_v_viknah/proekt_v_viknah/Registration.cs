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
            var writer = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\rate_info.txt",
                              System.IO.FileMode.Append, FileAccess.Write));

            var pib = Convert.ToString(textBoxPIB.Text);
            var grupa = Convert.ToString(textBoxGrupa.Text);

            writer.Write(pib);
            writer.Write(grupa);
            writer.Close();

            var reader = new System.IO.BinaryReader(
                              System.IO.File.OpenRead(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt"));
            int nstudents = reader.ReadInt32();
            reader.Close();
            nstudents += 1;

            var writer2 = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt",
                              System.IO.FileMode.Create));
            writer2.Write(nstudents);
            writer2.Close();

            Question1 qstn = new Question1();
            qstn.Show();
            Close();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
