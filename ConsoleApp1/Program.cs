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
            //Ball my_new_ball = new Ball();
            //Console.WriteLine("Enter your ball detail");
            //Console.WriteLine("size?");
            //my_new_ball.size = int.Parse(Console.ReadLine());
            //Console.WriteLine("type?");
            //my_new_ball.type = Console.ReadLine();
            //Console.WriteLine("color?");
            //my_new_ball.color = Console.ReadLine();
            //Console.WriteLine("fabric?");
            //my_new_ball.fabric = Console.ReadLine();
            Console.WriteLine("Enter your ball detail");
            Console.WriteLine("size?");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("color?");
            string color = Console.ReadLine();
            Console.WriteLine("type?");
            string type = Console.ReadLine();
            Console.WriteLine("fabric?");
            string fabric = Console.ReadLine();
            Ball my_new_ball = new Ball(size, color, type, fabric);
        }
    }
}
