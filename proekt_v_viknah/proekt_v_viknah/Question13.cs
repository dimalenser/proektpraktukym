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
    public partial class Question13 : Form
    {
        public Question13()
        {
            InitializeComponent();
        }

        private void Question13_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Чому дорівнює d, якщо int a = 0; int b = a ++; int c = 0; int d = a + b + c + 3 ?";
            richTextBoxAnswer1a.Text = "a) 3";
            richTextBoxAnswer1b.Text = "b) true";
            richTextBoxAnswer1c.Text = "c) false";
            richTextBoxAnswer1d.Text = "d) 4";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "d") Program.bal += 1;


            Question14 qstn14 = new Question14();
            qstn14.Show();
            Close();
        }
    }
}
