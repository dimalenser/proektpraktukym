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
    public partial class Question14 : Form
    {
        public Question14()
        {
            InitializeComponent();
        }

        private void Question14_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Для чого потрібні умовні оператори ?";
            richTextBoxAnswer1a.Text = "a) Щоб встановлювати умови користувачеві";
            richTextBoxAnswer1b.Text = "b) Для розгалуження програми";
            richTextBoxAnswer1c.Text = "c) Для оптимізації програми";
            richTextBoxAnswer1d.Text = "d) Щоб були";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question15 qstn15 = new Question15();
            qstn15.Show();
            Close();
        }
    }
}
