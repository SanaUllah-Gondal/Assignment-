// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Declare and initialize a 2D array with product details
        string[,] products =
        {
            {"Apple", "Fruits", "1.5", "50"},
            {"Milk", "Dairy", "2.0", "30"},
            {"Bread", "Bakery", "1.2", "40"},
            {"Eggs", "Dairy", "0.5", "100"},
            {"Rice", "Grains", "0.8", "60"}
        };

        // Display product details
        Console.WriteLine("Product Details:");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Name\tCategory\tPrice\tQuantity");
        Console.WriteLine("-----------------------------------------------");
        
        for (int i = 0; i < products.GetLength(0); i++)
        {
            Console.WriteLine($"{products[i, 0]}\t{products[i, 1]}\t{products[i, 2]}\t{products[i, 3]}");
        }

        Console.WriteLine("\nTotal Stock Value:");
        Console.WriteLine("-----------------------------------------------");
        
        for (int i = 0; i < products.GetLength(0); i++)
        {
            double price = Convert.ToDouble(products[i, 2]);
            int quantity = Convert.ToInt32(products[i, 3]);
            double stockValue = price * quantity;
            Console.WriteLine($"{products[i, 0]}: ${stockValue:F2}");
        }
    }
}
