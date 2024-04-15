// See https://aka.ms/new-console-template for more information

// C# LINQ:-
// Task 1:-
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var evenNumbers = numbers.Where(n => n % 2 == 0);

Console.WriteLine("Even numbers:");
foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}

Console.WriteLine("-------------------------------");

// Task 2:-

double[] grades = [98.4, 85.6, 99.9, 100];
foreach (double grade in grades)
{
    Console.WriteLine(grade);
}
double averageGrade = grades.Average();

Console.WriteLine($"\nThe average grade is: {averageGrade:F2}");

Console.WriteLine("-------------------------------");

// Bonus:-

//OrderBy:-

string[] names = ["Majed", "Othman", "Saleh", "Ahmad", "Nasser"];
var sortedNames = names.OrderBy(name => name);

Console.WriteLine("Sorted names in ascending order:");
foreach (var name in sortedNames)
{
    Console.WriteLine(name);
}

var sortedNamesDesc = names.OrderByDescending(name => name);

Console.WriteLine("-------------------------------");

Console.WriteLine("Sorted names in descending order:");
foreach (var name in sortedNamesDesc)
{
    Console.WriteLine(name);
}

Console.WriteLine("-------------------------------");

// GroupBy :-

var students = new List<(string Name, char Grade)>
        {
            ("Majed", 'A'), ("Othman", 'B'), ("Saleh", 'A'), ("Ahmad", 'D'), ("Nasser", 'C')
        };

var groupedByGrade = students.GroupBy(student => student.Grade);

foreach (var group in groupedByGrade)
{
    Console.WriteLine($"\nStudents with grade {group.Key}:\n");
    foreach (var student in group)
    {
        Console.WriteLine(student.Name);
    }
}

Console.WriteLine("---------------------");

// C# Functions

void greeting(string name)
{
    Console.WriteLine("Hello " + name + "!");
}

static int CalculateVolume(int length, int width, int height)
{
    return length * width * height;
}

greeting("Saleh");

int length = 5;
int width = 4;
int height = 3;

int volume = CalculateVolume(length, width, height);
Console.WriteLine($"The volume of the box is: {volume}");