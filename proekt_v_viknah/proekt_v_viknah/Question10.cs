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
    public partial class Question10 : Form
    {
        public Question10()
        {
            InitializeComponent();
        }

        private void Question10_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Чому буде дорівнює с, якщо int a = 10; int b = 4; bool c = (a == 10 && b == 4) ?";
            richTextBoxAnswer1a.Text = "a) true";
            richTextBoxAnswer1b.Text = "b) false";
            richTextBoxAnswer1c.Text = "c) Null";
            richTextBoxAnswer1d.Text = "d) 14";
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "a") Program.bal += 1;


            Question11 qstn11 = new Question11();
            qstn11.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
