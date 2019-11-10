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
    public partial class Question9 : Form
    {
        public Question9()
        {
            InitializeComponent();
        }

        private void Question9_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Чому буде дорівнює с, якщо int a = 10; int b = 4; int c = a% b ?";
            richTextBoxAnswer1a.Text = "a) 11";
            richTextBoxAnswer1b.Text = "b) 2";
            richTextBoxAnswer1c.Text = "c) 3";
            richTextBoxAnswer1d.Text = "d) 1";
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question10 qstn10 = new Question10();
            qstn10.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
