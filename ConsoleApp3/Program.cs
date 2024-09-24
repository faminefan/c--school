// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your price: ");
float a = float.Parse(Console.ReadLine());

Console.WriteLine("Enter znushka : ");
float b = float.Parse(Console.ReadLine());


decimal price = (decimal) (a - b * (a / 100));
Console.WriteLine($"Trip price: {price}uah");