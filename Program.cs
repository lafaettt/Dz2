using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Дмитрий Сергеевич";
            int age = 31;
            string mail = "marioivanov@mail.ru";
            double programmingPoints = 4.5;
            double mathScores = 5.6;
            double physicsPoints = 5.7;

            Console.WriteLine($"ФИО: {fullName} \nВозраст:{age} \nMail:{mail} \nБаллы по программированию:{programmingPoints} \nБаллы по математике:{mathScores} \nБаллы по физике:{physicsPoints}");

            double summ = programmingPoints + mathScores + physicsPoints;
            double srznach = summ / 3;
            Console.WriteLine($"Сумма баллов: {summ}");
            Console.WriteLine($"Среднее значение: {srznach}");
            Console.ReadKey();
        }
    }
    }

