using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balance_Ratios
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentAssets = 0;
            double inventories = 0;
            double currentLiabilities = 0;
            double equity = 0;
            double longTermDebt = 0;
            double shortTermDebt = 0;

            Console.WriteLine("Enter Current Assets");
            currentAssets = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Inventories");
            inventories = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Current Liabilities");
            currentLiabilities = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Shareholders Equity");
            equity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Long Term Debt");
            longTermDebt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Short Term Debt");
            shortTermDebt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Current Liabilities");
            currentLiabilities = Convert.ToDouble(Console.ReadLine());

            double tempVar = currentAssets - inventories;
            Console.WriteLine("Quick Ratio: " + tempVar / currentLiabilities);

           
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
