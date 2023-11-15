Dictionary<string, List<double>> students = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string student = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(student))
    {
        students.Add(student, new List<double>());
    }
    students[student].Add(grade);
}
var exelent = students.Where(st => st.Value.Average() >= 4.50);

foreach (var curentStudent in exelent)
{
    Console.WriteLine($"{curentStudent.Key} -> {curentStudent.Value.Average():F2}");
}