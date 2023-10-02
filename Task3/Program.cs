using System;

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(36.6M, 38.9M); 

        Console.WriteLine("Enter sum in UAN:");
        decimal amountInUAH = decimal.Parse(Console.ReadLine());

        Console.WriteLine("1. Convert in USD");
        Console.WriteLine("2. Convert in Euro");
        Console.WriteLine("3. Convert from USD in UAN");
        Console.WriteLine("4. Convert from Euro in UAN");
        Console.Write("Choose option (1/2/3/4): ");

        int choice = int.Parse(Console.ReadLine());

        decimal result = 0;

        switch (choice)
        {
            case 1:
                result = converter.ConvertToUSD(amountInUAH);
                Console.WriteLine($"Convert result: {result} USD");
                break;
            case 2:
                result = converter.ConvertToEuro(amountInUAH);
                Console.WriteLine($"Convert result: {result} Euro");
                break;
            case 3:
                Console.WriteLine("Enter sum in USD:");
                decimal amountInUSD = decimal.Parse(Console.ReadLine());
                result = converter.ConvertFromUSD(amountInUSD);
                Console.WriteLine($"Convert result: {result} UAH");
                break;
            case 4:
                Console.WriteLine("Введіть суму в Euro:");
                decimal amountInEuro = decimal.Parse(Console.ReadLine());
                result = converter.ConvertFromEuro(amountInEuro);
                Console.WriteLine($"Convert result: {result} UAH");
                break;
            default:
                Console.WriteLine("Wrong choice. Please try again");
                break;
        }
    }
}
