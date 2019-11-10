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
    public partial class Question16 : Form
    {
        public Question16()
        {
            InitializeComponent();
        }

        private void Question16_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Які бувають масиви ?";
            richTextBoxAnswer1a.Text = "a) Pізноманітні";
            richTextBoxAnswer1b.Text = "b) Складні і прості";
            richTextBoxAnswer1c.Text = "c) Одномірні і багатовимірні";
            richTextBoxAnswer1d.Text = "d) Гумові та статичні";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;


            Question17 qstn17 = new Question17();
            qstn17.Show();
            Close();
        }
    }
}
