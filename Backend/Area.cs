using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Backend
{
    class Area
    {
        decimal totalPrice, totalAreaPlusOverage, totalArea;
        private decimal length, width, overage, price;
        private String firstname, lastname;

        public Area() { }
        public void Run() {
            GetInput();
        }

        public void GetInput() {
            // GET FIRST
            Console.WriteLine("Enter your first name: ");
            firstname = Console.ReadLine();
            // GET LAST
            Console.WriteLine("Enter your last name: ");
            this.lastname = Console.ReadLine();
            // GET LENGTH
            Console.WriteLine("Enter the length of the room: ");
            String getLength = Console.ReadLine();
            this.length = decimal.Parse(getLength);
            // GET WIDTH
            Console.WriteLine("Enter the width of the room: ");
            String getWidth = Console.ReadLine();
            this.width = decimal.Parse(getWidth);
            // GET OVERAGE
            Console.WriteLine("Enter the percentage of overage for potential waste: ");
            String getOverage = Console.ReadLine();
            this.overage = decimal.Parse(getOverage);
            // GET PRICE
            Console.WriteLine("Enter the price per square foot: ");
            String getPrice = Console.ReadLine();
            this.price = decimal.Parse(getPrice);

            Calculate();
        }

        public void Calculate()
        {
            // CALCULATIONS
            this.totalPrice = GetTotalPrice(length, width, overage, price);
            this.totalArea = GetTotalArea(length, width);
            this.totalAreaPlusOverage = GetTotalAreaWithOverage(length, width, overage);

            Output();
        }

        public void Output() {
            Console.WriteLine(firstname.ToUpper() + " " + lastname.ToUpper() + "." + "\n");
            Console.WriteLine($"The area of a {length} long and {width} wide space is {totalArea:0.##} units. " +
                $"Adding in {overage}% overage is a total area of {totalAreaPlusOverage} units. " +
                $"With a cost of {price:C} per unit, the total cost is {totalPrice:C}");
        }
        


        private static decimal GetTotalArea(decimal length, decimal width)
        {
            decimal area = 0;
            area = length * width;
            return area;
        }
        private static decimal GetTotalAreaWithOverage(decimal length, decimal width, decimal overage)
        {
            decimal area = 0;
            area = length * width;
            area += (area * (overage / 100));
            return area;
        }
        static decimal GetTotalPrice(decimal length, decimal width, decimal overage, decimal price)
        {
            decimal area = 0;
            area = length * width;
            area += (area * (overage / 100));
            decimal total = area * price;
            return total;
        }
    }
}
