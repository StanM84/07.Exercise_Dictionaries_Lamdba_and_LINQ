Dictionary<string, string> registrars = new();

int n =int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] commandArray = Console.ReadLine().Split().ToArray();

    string command = commandArray[0];
    string employee = commandArray[1];

    if (command == "register")
    {
        
        string palteNum = commandArray[2];
        if (!registrars.ContainsKey(employee))
        {
            registrars.Add(employee, palteNum);
            Console.WriteLine($"{employee} registered {palteNum} successfully");
        }
        else
        {
            Console.WriteLine($"ERROR: already registered with plate number {registrars[employee]}");
        }
    }
    else if (command == "unregister")
    {
        if (registrars.ContainsKey(employee)) 
        {
            registrars.Remove(employee);
            Console.WriteLine($"{employee} unregistered successfully");
        }
        else 
        {
            Console.WriteLine($"ERROR: user {employee} not found");    
        }
    }
}
foreach (KeyValuePair<string, string> pair in registrars)
{
    Console.WriteLine($"{pair.Key} => {pair.Value}");
}