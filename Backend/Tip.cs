using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    class Tip
    {
        private decimal percent { get; set; }
        private decimal tip { get; set; }
        private decimal total { get; set; }
        private decimal amount { get; set; }

        public void GetData() {
            Console.WriteLine("Enter the amount: ");
            this.amount = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the tip percentage: ");
            this.percent = Decimal.Parse(Console.ReadLine());
            Calculate();
        }

        public void Calculate() {
            this.tip = (amount * (percent / 100));
            this.total = tip + amount;
            Output();
        }

        public void Run() {
            GetData();
        }

        public void Output() {
            Console.WriteLine($"For an amount of {amount:C} a {(percent/100):P} tip would be {tip:C} totalling {total:C}.");
        }
    }
}
