using lesson8_1;
using System.Diagnostics.Metrics;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson8_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleInteractions consoleInteractions = new ConsoleInteractions();
            string path = args.FirstOrDefault() ?? "gitignore.json";

            Shop oldShop = File.Exists(path) ? JsonSerializer.Deserialize<Shop>(File.ReadAllText("gitignore.json")) : null;

            Console.WriteLine($"Seller name {oldShop?.Salesman?.Name}");
            Console.WriteLine($"Position {oldShop?.Salesman?.JobTitle}");
            Console.WriteLine($"Product name {oldShop?.Product?.NameProduct}");
            Console.WriteLine($"The quantity of the item {oldShop?.Product?.Quantity}");

            Shop shop = new Shop
            {
                Salesman = new Salesman
                {
                    Name = consoleInteractions.RequestInput("Enter seller name") ?? oldShop?.Salesman.Name,
                    JobTitle = consoleInteractions.RequestInput("Enter position") ?? oldShop?.Salesman.JobTitle
                },
                Product = new Product
                {
                    NameProduct = consoleInteractions.RequestInput("Enter product name") ?? oldShop?.Product.NameProduct,
                    Quantity = int.Parse(consoleInteractions.RequestInput("Enter the quantity of the item") ?? oldShop?.Product.Quantity.ToString())
                }
            };

            File.WriteAllText(args.FirstOrDefault() ?? "gitignore.json", JsonSerializer.Serialize(shop, typeof(Shop)));
        }
    }
}