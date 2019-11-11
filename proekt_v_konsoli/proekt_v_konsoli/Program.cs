using System;
using System.IO;

namespace proekt_v_konsoli
{
    class Program
    {
        static void test()
        {
            
            string vidpovid;
            int bal = 0;
            Console.WriteLine("Введіть ваше прізвище, ім'я, по батькові");
            string pib =  (Console.ReadLine());
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
            Console.WriteLine(nstudents);
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

            //сортую масиви по спаданню рейтингу
            /*for (int i = 0; i < nstudents - 1; i++)
            {
                if (bal[i] > bal[i + 1])Console.WriteLine()
                
                else{
                    string max = bal[i].ToString();
                    bal[i] = bal[i + 1];
                    bal[i + 1] = Int32.Parse(max);

                    max = pib[i];
                    pib[i] = pib[i + 1];
                    pib[i + 1] = max;

                    max = grupa[i];
                    grupa[i] = grupa[i + 1];
                    grupa[i + 1] = max;
                }
            }
            */
            Console.WriteLine("Посортований рейтинг");
            Console.WriteLine("бал\tгрупа\tстудент");
            for (int i = 0; i < nstudents-1; i++)
            {
                Console.WriteLine($"{bal[i]}\t{grupa[i]}\t{pib[i]}");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тест на тему: 'Який у мене рівень математики?' ");
            Console.WriteLine("Розпочати тест нажміть 1,\nВийти з програми натисніть 0\nПереглянути рейтинг натисніть #");
            string a = (Console.ReadLine());
            if (a == "1") test();
            if (a == "0") System.Environment.Exit(-1);
            if (a == "#") rating();
            else
                Console.WriteLine("paka");
            //rating();
            Console.ReadLine();
        }
    }
}
