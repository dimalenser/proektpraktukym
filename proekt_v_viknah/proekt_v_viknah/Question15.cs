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
    public partial class Question15 : Form
    {
        public Question15()
        {
            InitializeComponent();
        }

        private void Question15_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що таке масив ?";
            richTextBoxAnswer1a.Text = "a) Набір однотипних даних, які розташовуються в пам'яті послідовно один за одним";
            richTextBoxAnswer1b.Text = "b) Набір даних типу int (32-біт ціле)";
            richTextBoxAnswer1c.Text = "c) Набір текстових значень у форматі Unicode, які розташовані у випадковому порядку";
            richTextBoxAnswer1d.Text = "d) Змінна";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "a") Program.bal += 1;


            Question16 qstn16 = new Question16();
            qstn16.Show();
            Close();
        }
    }
}
