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
    public partial class Question18 : Form
    {
        public Question18()
        {
            InitializeComponent();
        }

        private void Question18_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Які бувають цикли ?";
            richTextBoxAnswer1a.Text = "a) Великі і маленькі";
            richTextBoxAnswer1b.Text = "b) Цикл, Форіч, Подвійний цикл, Багаторазовий";
            richTextBoxAnswer1c.Text = "c) for, while, do-while, foreach";
            richTextBoxAnswer1d.Text = "d) ref, out, static, root";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "c") Program.bal += 1;


            Question19 qstn19 = new Question19();
            qstn19.Show();
            Close();
        }
    }
}
