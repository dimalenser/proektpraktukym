using System;

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

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тест на тему: 'Який у мене рівень математики?' ");
            Console.WriteLine("Розпочати тест нажміть 1,\nВийти з програми натисніть 0\nПереглянути рейтинг натисніть #");
            string a = (Console.ReadLine());
            if (a == "1") test();
            if (a == "0") System.Environment.Exit(-1);
            if (a == "#") Console.WriteLine("Рейтинг скоро буде");
            else
                Console.WriteLine("paka");
            Console.ReadLine();
        }
    }
}
