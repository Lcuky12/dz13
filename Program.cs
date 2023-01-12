using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people;
            int timeOne = 10;
            int hour;
            int minute;
            Console.Write(" Введите кол-во людей ");
            people = Convert.ToInt32(Console.ReadLine());
            hour = people * timeOne / 60;
            minute = people * timeOne % 60;
            Console.WriteLine(" Время ожидания " + (hour) + " часов " + (minute) + " минут ");
        }
    }
}
