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
    public partial class Question17 : Form
    {
        public Question17()
        {
            InitializeComponent();
        }

        private void Question17_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що таке цикл і для чого вони потрібні ?";
            richTextBoxAnswer1a.Text = "a) Цикли потрібні для багаторазового запуску програми";
            richTextBoxAnswer1b.Text = "b) Цикли потрібні для багаторазового виконання коду";
            richTextBoxAnswer1c.Text = "c) Цикли потрібні для багаторазового розміщення даних";
            richTextBoxAnswer1d.Text = "d) Цикли потрібні щоб виконати код без помилок";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question18 qstn18 = new Question18();
            qstn18.Show();
            Close();
        }
    }
}
