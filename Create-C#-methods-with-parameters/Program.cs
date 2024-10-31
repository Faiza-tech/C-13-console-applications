void countTo(int max)
{
    for (int i = 0; i < max; i++)
    {
        Console.WriteLine("value is: " + i);
    }
}

countTo(5);//  the integer 5 is supplied as an argument.



Console.WriteLine("**********************");

int[] schedule = { 800, 1200, 1600, 2000 };

void displayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

displayAdjustedTimes(schedule, 6, -6);

Console.WriteLine("**********************");

string[] students = { "Jenna", "Ayesha", "Carlos", "Viktor" };

void displayStudent(string[] students)
{
    foreach (string student in students)
    {
        Console.WriteLine(student);
    }
}

displayStudent(students);
displayStudent(new string[] { "zara", "sara" });

Console.WriteLine("**********************");

double pi = 3.14;

void circleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

//circleArea(12);

void CircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}
//CircleCircumference(24);


void printCircle(int radius)
{
    Console.WriteLine($"Circle with radius {radius}");
    circleArea(radius);
    CircleCircumference(radius);
}

printCircle(12);
printCircle(24);

Console.WriteLine("**********************");

// Test pass by value
int a = 3;
int b = 4;
int c = 0;

void multiply(int a, int b, int c)
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}

multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");


Console.WriteLine("**********************");
// Test pass by reference

int[] array = { 1, 2, 3, 4, 5 };

void printArray(int[] array)
{

    foreach (int i in array)
    {
        Console.Write("Array values are: " + i);
    }
    Console.WriteLine();
}

printArray(array);

void clear(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = 0;
    }
}

clear(array);
printArray(array);

Console.WriteLine("**********************");
//Test with strings

string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy)
{
    status = isHealthy ? "Healthy" : "Unhealthy";
    Console.WriteLine($"Middle: {status}");
}