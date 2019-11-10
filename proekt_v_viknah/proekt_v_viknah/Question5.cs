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
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "d") Program.bal += 1;


            Question6 qstn6 = new Question6();
            qstn6.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Question5_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як знайти квадратний корінь з числа x ?";
            richTextBoxAnswer1a.Text = "a) Sqrt (x)";
            richTextBoxAnswer1b.Text = "b) Summ.Koren (x)";
            richTextBoxAnswer1c.Text = "c) Arifmetic.sqrt (x)";
            richTextBoxAnswer1d.Text = "d) Math.Sqrt (x)";
        }
    }
}
