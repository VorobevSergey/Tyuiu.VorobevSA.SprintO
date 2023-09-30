using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VorobevSA.Sprint0.TaskReview.lib;

namespace Tyuiu.VorobevSA.Sprint0.TaskReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Воробьев С.А. | ПКДб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: SprintReview #0 Заданиt                                           *");
            Console.WriteLine("* Задание  SprintReview#0                                                 *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил:Воробьев Сергей Александрович | ПКТб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на С#, которая суммирует значение трёх    *");
            Console.WriteLine("* цисел умноженную на 5                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите целые числа");
            Console.Write("Введите цисло X= ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цисло Y= ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цисло Z= ");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("(X+Y+Z)*5= " + DataService.Calc(x, y, z));
            Console.ReadKey();
        }
    }
}
