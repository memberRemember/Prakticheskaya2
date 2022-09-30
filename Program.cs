using System;
using System.Security.Cryptography;

namespace Prakticheskaya2
{
    class Program    
    {
        static void Main(string[] args)
           {

            bool NegrPashet = true;
            do
            {
                Console.WriteLine("     =~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
                Console.WriteLine("     Выберите какую операцию вы хотите выполнить:");
                Console.WriteLine("     [1] Угадай число");
                Console.WriteLine("     [2] Таблица умножения");
                Console.WriteLine("     [3] Вывод делителей числа");
                Console.WriteLine("     [4] Закрыть программу");
                Console.WriteLine("     =~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=~=");
                int operationNum;
                Console.Write("     Введите номер операции: ");
                operationNum = Convert.ToInt32(Console.ReadLine());

                if (operationNum == 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("     ### Рандомайзер выбрал число ###");
                    Randomizer();
                }
                if (operationNum == 2)
                {
                    Console.WriteLine("");
                    TablUmn();
                }   
                if (operationNum == 3)
                {
                    DelChisla();
                }
                
                if (operationNum == 4)
                {
                    NegrPashet = false;
                }
            }

            while (NegrPashet == true);
            {
                Console.WriteLine("");
                Console.WriteLine("     ### Завершение программы... ###");
            }

        }

        public static string Randomizer()
           {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            bool Ugadal = false;
            do
            {
                Console.Write("Угадай число: ");
                int b;
                b = Convert.ToInt32(Console.ReadLine());

                if (b > a)
                {
                    Console.WriteLine("Меньше!");
                }
                else if (b < a)
                {
                    Console.WriteLine("Больше!");
                }
                else
                {
                    Ugadal = true;
                }
            }
            while (Ugadal == false);
                    {
                        string result = "Вы угадали!";
                        Console.WriteLine(result);
                        return result;
                    }
            
        }
        public static string TablUmn()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("\t" + i * j);
                }
                Console.WriteLine("");
                Console.WriteLine("");
            }
            return null;
        }
        public static string DelChisla()
        {
            Console.WriteLine("");
            Console.Write("     Введите число: ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0)
                {
                    Console.Write("     [" + "{0} ", a + "]");
                }
            }
            Console.WriteLine("");
            return null;
        }
    }
}

