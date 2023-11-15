Dictionary<string, int> resources = new();

string resource = Console.ReadLine();

while (resource != "stop")
{
    int quontity = int.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources.Add(resource, quontity);
    }
    else
    {
        resources[resource] += quontity;
    }

    resource = Console.ReadLine();
}
foreach (KeyValuePair<string, int> pair in resources)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}