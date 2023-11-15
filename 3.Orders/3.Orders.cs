Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);

    if (!products.ContainsKey(product))
    {
        products.Add(product, new() { price, quantity });
    }
    else
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }

    input = Console.ReadLine();
}
foreach (KeyValuePair<string, List<decimal>> currentProducts in products)
{
    string product = currentProducts.Key;
    decimal price = currentProducts.Value[0];
    decimal quantity = currentProducts.Value[1];

    decimal currentProductAmount = price * quantity;

    Console.WriteLine($"{product} -> {currentProductAmount:F2}");
}