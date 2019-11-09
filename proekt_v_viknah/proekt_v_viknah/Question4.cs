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
            Result rslt = new Result();
            rslt.Show();
            Close();


        }

        private void Question4_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Cкільки буде 4 + 4 * 4 ?";
            richTextBoxAnswer1a.Text = "a) 16";
            richTextBoxAnswer1b.Text = "b) 20";
            richTextBoxAnswer1c.Text = "c) 25";
            richTextBoxAnswer1d.Text = "d) 16";
        }
    }
}
