namespace carpet_cleaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int SmallCarpetPrice = 25;
            int LargeCarpetPrice = 35;
            double SalesTaxRate = 0.06;

            Console.WriteLine("Enter the number of small carpets:");
            int smallCarpets = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of large carpets: ");
            int largeCarpts = int.Parse(Console.ReadLine());

            double SmallCarpetCost = SmallCarpetPrice * smallCarpets;
            double LargeCarpetCost = LargeCarpetPrice * largeCarpts;
            double SmallCarpetTax = SmallCarpetCost * SalesTaxRate;
            double LargeCarpetTax = LargeCarpetCost * SalesTaxRate;

            double cost = (SmallCarpetPrice * smallCarpets) + (LargeCarpetPrice * largeCarpts);
            double tax = cost * SalesTaxRate;
            double total = tax + cost;
            Console.WriteLine("Estimate for carpet cleaning service:");
            Console.WriteLine($"Number of small carpets:{smallCarpets}");
            Console.WriteLine($"Number of large carpets{largeCarpts}"); 
            Console.WriteLine($"SmallCarpetCost: ${SmallCarpetCost}");
            Console.WriteLine($"LargeCarpetCost: ${LargeCarpetCost}");
            
            Console.WriteLine($"Tax: ${tax}");
            Console.WriteLine($"Total estimate: ${total}");
            Console.WriteLine("This estimate is vaild for 30 days.");
                

        }
    }
}