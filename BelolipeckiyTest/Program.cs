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
            function.SetInspector();
            function.GenerateNumber();
            function.GetWorker();
            /*function.AddWorker();*/
        }
    }
}
