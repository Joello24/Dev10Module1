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
            
            Console.WriteLine($"Given num {ConditionalDemo.num}, target {ConditionalDemo.target}, and {ConditionalDemo.range}" +
                $". The result is: {ConditionalDemo.IsWithinRange().ToString()}");
        }
    }
}
