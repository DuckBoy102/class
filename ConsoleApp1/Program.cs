using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball my_new_ball = new Ball();
            Console.WriteLine("Enter your ball detail");
            Console.WriteLine("size?");
            my_new_ball.set_size (int.Parse(Console.ReadLine()));
            Console.WriteLine("color?");
            my_new_ball.set_color(Console.ReadLine());
        }
    }
}
