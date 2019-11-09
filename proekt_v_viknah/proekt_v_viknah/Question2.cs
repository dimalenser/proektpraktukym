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
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion2_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "d") Program.bal += 1;
            Question3 qstn3 = new Question3();
            qstn3.Show();
            Close();
        }

        private void Question2_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Cкільки буде 2 + 2 * 2 ?";
            richTextBoxAnswer1a.Text = "a) 0";
            richTextBoxAnswer1b.Text = "b) 1";
            richTextBoxAnswer1c.Text = "c) 2";
            richTextBoxAnswer1d.Text = "d) 6";
        }
    }
}
