using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;

namespace BelolipeckiyTest
{
    class Program
    {
        static FunctionInsp function = new FunctionInsp();

        static void Main(string[] args)
        {
            Begin();
            Console.ReadKey();
        }

        static void Begin()
        {
            Console.WriteLine("Выберите действие:\n1 - Изменить Главного инспектора" +
                "\n2 - Сгенерировать автомобильный номер\n3 - Вывести список сотрудников" +
                "\n4 - Добавить сотрудников\n5 - Вывести имя главного инспектора\n6 - Вывести название автоинспекции");
            Middle();
        }

        static void Middle()
        {
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (a == 1)
            {
                string fullname = "";
                Console.WriteLine(function.SetInspector(fullname));
                Begin();
            }
            else if (a == 2)
            {
                int number;
                string symbol = "";
                int code;

                Random rand = new Random();
                number = rand.Next(10, 99);                                                                //Выбираются рандомные числа от 10 до 99
                int symbValue = rand.Next(0, 26);                                                          //Выбираются рандомные числа от 0 до 26
                char letter = Convert.ToChar(symbValue + 65);

                symbol = symbol + letter;

                code = rand.Next(1, 150);                                                                  //Выбираются рандомные числа от 1 до 150

                function.GenerateNumber(number,symbol,code);
                Begin();
            }
            else if (a == 3)
            {
                function.GetWorker();
                Begin();
            }
            else if (a == 4)
            {
                function.AddWorker();
                Begin();
            }
            else if (a == 5)
            {
                function.GetInspector();
                Begin();
            }
            else if (a == 6)
            {
                function.GetCarInspection();
                Begin();
            }
            else
            {
                End();
            }
        }

        static void End()
        {
            Console.Clear();
            Begin();
        }
    }
}
