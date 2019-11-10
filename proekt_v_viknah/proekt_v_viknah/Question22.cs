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
    public partial class Question22 : Form
    {
        public Question22()
        {
            InitializeComponent();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
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

            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;

            var writer = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\rate_info.txt",
                              System.IO.FileMode.Append, FileAccess.Write));


            writer.Write(Program.pib);
            writer.Write(Program.grupa);
            writer.Write(Program.bal);

            writer.Close();
            Result rslt = new Result();
            rslt.Show();
            Close();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Question22_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що таке Купа ?";
            richTextBoxAnswer1a.Text = "a) Це структура даних";
            richTextBoxAnswer1b.Text = "b) Іменована область пам'яті";
            richTextBoxAnswer1c.Text = "c) Область динамічної пам'яті ";
            richTextBoxAnswer1d.Text = "d) Купа змінних";
        }
    }
}
