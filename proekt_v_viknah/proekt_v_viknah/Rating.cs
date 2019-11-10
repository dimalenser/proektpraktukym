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
    public partial class Rating : Form
    {
        public Rating()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonGoToTest_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            reg.Show();
            Close();
        }

        private void Rating_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"C:\Users\diman\Documents\GitHub\proektpraktukym\rate_info.txt") == false || System.IO.File.Exists(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt") == false) return;
            //створення потоку читач
            var readnstudents = new System.IO.BinaryReader(
                              System.IO.File.OpenRead(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt"));
            int nstudents = readnstudents.ReadInt32();
            readnstudents.Close();

            string[] pib = new string[nstudents];
            string[] grupa = new string[nstudents];
            int[] bal = new int[nstudents];
            var reader = new System.IO.BinaryReader(
                              System.IO.File.OpenRead(@"C:\Users\diman\Documents\GitHub\proektpraktukym\rate_info.txt"));

            //Console.WriteLine("бал\tгрупа\tстудент");
            for (int i = 0; i < nstudents - 1; i++)
            {
                pib[i] = reader.ReadString();
                grupa[i] = reader.ReadString();
                bal[i] = reader.ReadInt32();
                //Зчитав всі дані з файлу і записав в масиви

            }

            reader.Close();

            for (int i = 0; i < nstudents; i++)
            {
                for (int j = 0; j < nstudents - 2; j++)
                {
                    if (bal[j] < bal[j + 1])
                    {
                        string max = bal[j].ToString();
                        bal[j] = bal[j + 1];
                        bal[j + 1] = Int32.Parse(max);

                        max = pib[j];
                        pib[j] = pib[j + 1];
                        pib[j + 1] = max;

                        max = grupa[j];
                        grupa[j] = grupa[j + 1];
                        grupa[j + 1] = max;
                    }
                }
            }
            richTextBox1.Clear();
            richTextBox1.Text="№\t\tБал\t\tГрупа\t\tПІБ\n";
            for (int i = 0; i < nstudents - 1; i++)
            {
                richTextBox1.AppendText($"{i+1}\t\t{bal[i]}\t\t{grupa[i]}\t\t{pib[i]}\n");
            }
            
        }
    }
}
