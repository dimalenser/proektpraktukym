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
    public partial class Question21 : Form
    {
        public Question21()
        {
            InitializeComponent();
        }

        private void Question21_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Що означає ключове слово var ?";
            richTextBoxAnswer1a.Text = "a) Bлаштовує війну між програмами";
            richTextBoxAnswer1b.Text = "b) Позначає що змінна без явного типу даних";
            richTextBoxAnswer1c.Text = "c) Позначає що змінна має явний тип даних";
            richTextBoxAnswer1d.Text = "d) Такого слова немає в C#";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion1_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "b") Program.bal += 1;


            Question22 qstn22 = new Question22();
            qstn22.Show();
            Close();
        }
    }
}
