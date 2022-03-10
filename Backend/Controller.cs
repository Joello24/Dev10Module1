using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Backend;
using static HelloWorld.Backend.ConditionalDemo;


namespace HelloWorld
{
    class Controller
    {
        static void Main(string[] args) {
            //Area tester = new Area();
            //tester.Run();

            //StringConcat tester2 = new StringConcat();
            //tester2.Run();

            //Tip tester3 = new Tip();
            //tester3.Run();

            Console.WriteLine($"Output: {ConditionalDemo.isWithinRange(12, 10, 2).ToString()} Hi");
        }
    }
}
