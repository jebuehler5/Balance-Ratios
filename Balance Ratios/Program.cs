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
            double totalAssets = 0;
            double inventories = 0;
            double currentLiabilities = 0;
            double totalLiabilities = 0;
            double equity = 0;
            double longTermDebt = 0;
            double shortTermDebt = 0;
            double receivables = 0;
            double revenue = 0;
            string[] overallHealth = { "Bad", "Somewhat Bad", "Fair", "Good", "Great" };
            string[] stockRecommendation = { "Don't Buy", "Buy"};

            Console.WriteLine("Enter Current Assets");
            currentAssets = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Total Assets");
            currentAssets = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Inventories");
            inventories = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Current Liabilities");
            currentLiabilities = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Total Liabilities");
            totalLiabilities = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Shareholders Equity");
            equity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Long Term Debt");
            longTermDebt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Short Term Debt");
            shortTermDebt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Receivables");
            receivables = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Revenue");
            revenue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------Results----------------------");
            Console.WriteLine("----------------------------------------------------");

            double tempVar1 = currentAssets - inventories;
            Console.WriteLine("Quick Ratio: " + tempVar1 / currentLiabilities);
            Console.WriteLine("Current Ratio: " + currentAssets / currentLiabilities);
            Console.WriteLine("Total Debt/Equity Ratio: " + totalLiabilities / equity);
            Console.WriteLine("Long Term Debt/Equity Ratio: " + longTermDebt / equity);
            Console.WriteLine("Short Term Debt/Equity Ratio: " + shortTermDebt / equity);
            Console.WriteLine("Days Sales Outstanding: " + receivables / revenue);
            Console.WriteLine("Inventory % of Revenue: " + inventories / revenue);
            Console.WriteLine("Long Term Debt as % of Total Debt: " + longTermDebt / totalLiabilities);
            Console.WriteLine("Short Term Debt as % of Total Debt: " + shortTermDebt / totalLiabilities);
            Console.WriteLine("Total Liabilities % of Total Assets: " + totalLiabilities / totalAssets);

            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------Stock Health------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Overall health: " + overallHealth);
            Console.WriteLine("Recommendation: " + stockRecommendation);


            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
