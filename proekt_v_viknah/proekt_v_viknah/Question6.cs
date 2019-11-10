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
    public partial class Question6 : Form
    {
        public Question6()
        {
            InitializeComponent();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;


            Question7 qstn7 = new Question7();
            qstn7.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Question6_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як позначають оператор «НЕ»?";
            richTextBoxAnswer1a.Text = "a) Not";
            richTextBoxAnswer1b.Text = "b) No";
            richTextBoxAnswer1c.Text = "c) !";
            richTextBoxAnswer1d.Text = "d) !=";
        }
    }
}
