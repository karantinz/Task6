using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string zodiacSign;
            string work;

            Console.Write("Как вас зовут - ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Сколько вам лет - ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Какой ваш знак зодиака - ");
            zodiacSign = Convert.ToString(Console.ReadLine());

            Console.Write("Где вы работаете - ");
            work = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Вас зовут " + name + ", вам " + age + " год," + " вы " + zodiacSign + " и работаете на " + work);
            Console.ReadKey();
        }
    }
}
