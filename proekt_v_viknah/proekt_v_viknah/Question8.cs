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
    public partial class Question8 : Form
    {
        public Question8()
        {
            InitializeComponent();
        }

        private void Question8_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як позначають оператор «І»?";
            richTextBoxAnswer1a.Text = "a) and";
            richTextBoxAnswer1b.Text = "b) &&";
            richTextBoxAnswer1c.Text = "c) &";
            richTextBoxAnswer1d.Text = "d) Всі вище перераховані";
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question9 qstn9 = new Question9();
            qstn9.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
