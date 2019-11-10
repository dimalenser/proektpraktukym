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
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion4_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question5 qstn5 = new Question5();
            qstn5.Show();
            Close();
        }

        private void Question4_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як зробити декрементацію числа ?";
            richTextBoxAnswer1a.Text = "a) %%";
            richTextBoxAnswer1b.Text = "b) --";
            richTextBoxAnswer1c.Text = "c) !=";
            richTextBoxAnswer1d.Text = "d) ++";
        }
    }
}
