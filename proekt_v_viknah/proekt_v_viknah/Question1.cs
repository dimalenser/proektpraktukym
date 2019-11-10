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
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void Question1_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що робить оператор «%» ?";
            richTextBoxAnswer1a.Text = "a) Ні чого з вище перерахованого";
            richTextBoxAnswer1b.Text = "b) Повертає тригонометричну функцію";
            richTextBoxAnswer1c.Text = "c) Повертає відсоток від суми";
            richTextBoxAnswer1d.Text = "d) Повертає залишок від ділення";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "d") Program.bal +=1;
            Question2 qstn2 = new Question2();
            qstn2.Show();
            Close();
        }

        
    }
}
