using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint0.Task6.V0.lib;

namespace Tyuiu.VorobevSA.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayunums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arrayunums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arrayunums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arrayunums));
            Console.ReadKey();
        }
    }
}
