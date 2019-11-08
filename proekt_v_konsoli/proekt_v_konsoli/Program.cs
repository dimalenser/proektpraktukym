using System;

namespace proekt_v_konsoli
{
    class Program
    {
        static void test()
        {
            Console.WriteLine("Введіть ваше прізвище, ім'я, по батькові");
            string pib =  (Console.ReadLine());
            Console.WriteLine("Введіть номер вашої групи");
            string grupa = (Console.ReadLine());
            Console.WriteLine(pib + grupa);

            //----------------------------
            Console.WriteLine("Питання 1\n скільки буде 2+2*2?");
            Console.WriteLine("a)0\n b)1\n c)2\nd)6 ");
            string vidpovid = (Console.ReadLine());
            int bal = 0;
            if (vidpovid == "d") vidpovid += 1;
            Console.WriteLine(vidpovid);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Тест на тему: 'Якась тема' ");
            Console.WriteLine("Розпочати тест нажміть 1,\nВийти з програми натисніть 0\nПереглянути рейтинг натисніть #");
            string a;
            test();
            Console.ReadLine();
        }
    }
}
