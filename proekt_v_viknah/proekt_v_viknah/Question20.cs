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
    public partial class Question20 : Form
    {
        public Question20()
        {
            InitializeComponent();
        }

        private void Question20_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що таке константа ?";
            richTextBoxAnswer1a.Text = "a) Змінна типу string";
            richTextBoxAnswer1b.Text = "b) Змінна, яка може бути змінена в будь-який час";
            richTextBoxAnswer1c.Text = "c) Глобальна змінна";
            richTextBoxAnswer1d.Text = "d) Змінна, значення якої не можна змінити";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "d") Program.bal += 1;


            Question21 qstn21 = new Question21();
            qstn21.Show();
            Close();
        }
    }
}
