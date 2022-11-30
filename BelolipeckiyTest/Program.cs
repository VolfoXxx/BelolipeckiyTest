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

        static void Main(string[] args)
        {
            FunctionInsp function = new FunctionInsp();

            function.GetInspector();
            function.GetCarInspection();

            Begin();
            
            
            Console.ReadKey();
        }

        static void Begin()
        {
            FunctionInsp function = new FunctionInsp();

            Console.WriteLine("Выберите действие:\n1 - Изменить Главного инспектора\n2 - Сгенерировать автомобильный номер\n3 - Вывести список сотрудников\n4 - Добавить сотрудников");

            Middle();
        }

        static void Middle()
        {

            FunctionInsp function = new FunctionInsp();

            int a = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (a == 1)
            {
                function.SetInspector();
                Begin();
            }
            else if (a == 2)
            {
                function.GenerateNumber();
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
