﻿using System;
using System.IO;
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
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNexQuestion3_Click(object sender, EventArgs e)
        {
            string vidpovid = textBox1.Text;
            if (vidpovid == "a") Program.bal += 1;
        

            Question4 qstn4 = new Question4();
            qstn4.Show();
            Close();
        }

        private void Question3_Load(object sender, EventArgs e)
        {
            richTextBoxQuestion1.Text = "Як зробити інкрементацію числа ?";
            richTextBoxAnswer1a.Text = "a) ++";
            richTextBoxAnswer1b.Text = "b) --";
            richTextBoxAnswer1c.Text = "c) %%";
            richTextBoxAnswer1d.Text = "d) !=";
        }
    }
}
