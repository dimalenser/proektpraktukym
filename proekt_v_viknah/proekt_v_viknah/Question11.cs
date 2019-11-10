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
    public partial class Question11 : Form
    {
        public Question11()
        {
            InitializeComponent();
        }

        private void Question11_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Чому буде дорівнює с, якщо int a = 0; int c = a-- ?";
            richTextBoxAnswer1a.Text = "a) Null";
            richTextBoxAnswer1b.Text = "b) -1";
            richTextBoxAnswer1c.Text = "c) 0";
            richTextBoxAnswer1d.Text = "d) 1";
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;


            Question12 qstn12 = new Question12();
            qstn12.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
