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
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void Question7_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як позначають оператор «АБО» ?";
            richTextBoxAnswer1a.Text = "a) !";
            richTextBoxAnswer1b.Text = "b) !=";
            richTextBoxAnswer1c.Text = "c) ||";
            richTextBoxAnswer1d.Text = "d) Or";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;


            Question8 qstn8 = new Question8();
            qstn8.Show();
            Close();
        }
    }
}
