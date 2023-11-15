Dictionary<string, List<string>> companies = new();

string input = Console.ReadLine();

while (input != "End")
{
    string[] inputArray = input.Split(" -> ");
    string company = inputArray[0];
    string nameID = inputArray[1];

    if (!companies.ContainsKey(company))
    {
        companies.Add(company, new List<string>());
    }
    if (!companies[company].Contains(nameID))
    {
        companies[company].Add(nameID);
    }

    input = Console.ReadLine();
}
foreach (KeyValuePair<string, List<string>> currentCompany in companies)
{
    Console.WriteLine(currentCompany.Key);

    foreach (string currentNameID  in currentCompany.Value)
    {
        Console.WriteLine($"-- {currentNameID}");
    }
}