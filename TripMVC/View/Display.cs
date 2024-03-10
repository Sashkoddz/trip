using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip.View
{
    public class Display
    {
        public Display()
        {
            this.Money = 0;
            this.Season = "";
            this.TotalPrice = 0;
            this.GetValue();
        }
        public int Money { get; set; }
        public string Season { get; set; }
        public double TotalPrice { get; set; }
        public void GetValue()
        {
            Console.WriteLine("Enter Money:");
            this.Money = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Enter time of the year:");
            this.Season = Console.ReadLine()!;
        }
        public void ShowPrice()
        {
            if (this.Money <= 100) 
            {
                if (this.Season == "summer")
                {
                    Console.WriteLine($"Somewhere in Bulgaria Camp - {this.TotalPrice:F2}");
                }
                else if (this.Season == "winter")
                {
                    Console.WriteLine($"Somewhere in Bulgaria Hotel - {this.TotalPrice:F2}");
                }
                
            }
            else if (this.Money <= 1000)
            {
                if (this.Season == "summer")
                {
                    Console.WriteLine($"Somewhere in Balkans Camp - {this.TotalPrice:F2}");
                }
                else if (this.Season == "winter")
                {
                    Console.WriteLine($"Somewhere in Balkans Hotel - {this.TotalPrice:F2}");
                }
            }
            else
            {
                Console.WriteLine($"Somewhere in Europe Hotel - {this.TotalPrice:F2}");
            }
        }
    }
}
