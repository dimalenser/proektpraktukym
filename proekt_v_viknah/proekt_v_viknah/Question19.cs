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
    public partial class Question19 : Form
    {
        public Question19()
        {
            InitializeComponent();
        }

        private void Question19_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Який оператор повертає значення з методу ?";
            richTextBoxAnswer1a.Text = "a) nani";
            richTextBoxAnswer1b.Text = "b) return";
            richTextBoxAnswer1c.Text = "c) out";
            richTextBoxAnswer1d.Text = "d) end";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question20 qstn20 = new Question20();
            qstn20.Show();
            Close();
        }
    }
}
