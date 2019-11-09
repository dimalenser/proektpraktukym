using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proekt_v_viknah
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void test()
        {
            string vidpovid;
            int bal = 0;
            Console.WriteLine("Введіть ваше прізвище, ім'я, по батькові");
            string pib = (Console.ReadLine());
            Console.WriteLine("Введіть номер вашої групи");
            string grupa = (Console.ReadLine());
            Console.WriteLine(pib + grupa);

            //----------------------------
            Console.WriteLine("Питання 1\n скільки буде 1+1*1?");
            Console.WriteLine("a)0\nb)1\nc)2\nd)6 ");
            vidpovid = (Console.ReadLine());
            if (vidpovid == "c") bal += 1;
            Console.WriteLine(bal);

            //----------------------------
            Console.WriteLine("\nПитання 2\n скільки буде 2+2*2?");
            Console.WriteLine("a)0\nb)1\nc)2\nd)6 ");
            vidpovid = (Console.ReadLine());
            if (vidpovid == "d") bal += 1;
            Console.WriteLine(bal);

            //----------------------------
            Console.WriteLine("\nПитання 3\n скільки буде 3+3*3?");
            Console.WriteLine("a)12\nb)3\nc)9\nd)6 ");
            vidpovid = (Console.ReadLine());
            if (vidpovid == "a") bal += 1;
            Console.WriteLine(bal);

            //----------------------------
            Console.WriteLine("Питання 4\n скільки буде 4+4*4?");
            Console.WriteLine("a)16\nb)20\nc)25\nd)16 ");
            vidpovid = (Console.ReadLine());
            if (vidpovid == "b") bal += 1;
            Console.WriteLine(bal);

            var writer = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\rate_info.txt",
                              System.IO.FileMode.Append, FileAccess.Write));
            writer.Write(pib);
            writer.Write(grupa);
            writer.Write(bal);
            writer.Close();

            var reader = new System.IO.BinaryReader(
                              System.IO.File.OpenRead(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt"));
            int nstudents = reader.ReadInt32();
            reader.Close();
            nstudents += 1;

            var writer2 = new System.IO.BinaryWriter(
                              System.IO.File.Open(@"C:\Users\diman\Documents\GitHub\proektpraktukym\nstudents.txt",
                              System.IO.FileMode.Create));
            writer2.Write(nstudents);
            writer2.Close();

        }

        static void rating()
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

            Console.WriteLine("бал\tгрупа\tстудент");
            for (int i = 0; i < nstudents - 1; i++)
            {
                pib[i] = reader.ReadString();
                grupa[i] = reader.ReadString();
                bal[i] = reader.ReadInt32();
                Console.WriteLine($"{bal[i]}\t{grupa[i]}\t{pib[i]}");

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
        }


            static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
            string text = "test";
        }
    }
}
