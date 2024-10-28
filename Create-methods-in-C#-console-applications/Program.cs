
Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");
void SayHello()
{
    Console.WriteLine("Hello World!");
}


//Create a method to display random numbers
void displayRandomNumbers()
{
    Random random = new Random();
    for (int i = 0; i < 6; i++)
    {
        int numb = random.Next(0, 10);
        Console.WriteLine("Random numbers are:" + numb);
    }
    Console.WriteLine();
}

Console.WriteLine("Generating random numbers:");
displayRandomNumbers();


Console.WriteLine("********************");
/* Create a list with some initial items
       List<string> myList = new List<string> { "apple", "banana", "cherry" };

       // Display the list
       Console.WriteLine("List before inserting:");
       myList.ForEach(item => Console.WriteLine(item));

       // Insert a new item at a specific position
       myList.Insert(1, "orange"); // Insert "orange" at index 1

       // Display the updated list
       Console.WriteLine("\nList after inserting:");
       myList.ForEach(item => Console.WriteLine(item));*/
/////////////////////////////////////////

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

void DisplayTimes()
{
    /* Format and display medicine times */
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            // For lengths 3 or more (e.g., 120 or 1200), insert ':' before the last two digits.
            // Example: 120 becomes 1:20, and 1200 becomes 12:00
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            // For length equal to 2 (e.g., 20), prepend '0:' to ensure proper format.
            // Example: 20 becomes 0:20
            time = time.Insert(0, "0:");
        }
        else
        {
            // For length less than 2 (e.g., 5), prepend '0:0' to ensure proper format.
            // Example: 5 becomes 0:05
            time = time.Insert(0, "0:0");
        }

        // Output the formatted time
        Console.Write($"{time} ");
    }

    Console.WriteLine(); // Move to the next line after displaying all times
}

void AdjustTimes()
{
    /* Adjust the times by adding the difference, keeping the value within 24 hours */
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}




// just number allowed not string
/*
using System;

class Program
{
    static int[] times = { 800, 1200, 1600, 2000 }; // Medicine schedule in HHMM format
    static int diff = 0;

    static void Main()
    {
        // Get current GMT with input validation
        int currentGMT = GetValidGMT("Enter current GMT: ");

        Console.WriteLine("Current Medicine Schedule:");
        DisplayTimes();

        // Get new GMT with input validation
        int newGMT = GetValidGMT("Enter new GMT: ");

        // Validate GMT range and adjust times accordingly
        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT. Please enter a value between -12 and 12.");
        }
        else
        {
            // Calculate the difference based on the current and new GMT
            if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            }

            AdjustTimes(); // Adjust the medicine schedule based on the calculated difference
            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes();
        }
    }

    static int GetValidGMT(string prompt)
    {
        int gmt;
        while (true)
        {
            Console.Write(prompt);
            string userInput = Console.ReadLine(); // Read input as a string

            // Try to convert the input to an integer
            if (int.TryParse(userInput, out gmt))
            {
                return gmt; // Return the valid integer if conversion is successful
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
        }
    }

    static void DisplayTimes()
    {
        //* Format and display medicine times 
        foreach (int val in times)
        {
            string time = val.ToString();
            int len = time.Length;

            if (len >= 3)
            {
                // Insert ':' before the last two digits
                time = time.Insert(len - 2, ":");
            }
            else if (len == 2)
            {
                // Prepend '0:' for two-digit minutes
                time = time.Insert(0, "0:");
            }
            else
            {
                // Prepend '0:0' for single-digit minutes
                time = time.Insert(0, "0:0");
            }

            // Output the formatted time
            Console.Write($"{time} ");
        }

        Console.WriteLine(); // Move to the next line after displaying all times
    }

    static void AdjustTimes()
    {
        //* Adjust the times by adding the difference, keeping the value within 24 hours 
        for (int i = 0; i < times.Length; i++)
        {
            // Ensure positive adjustment and keep the values within 0 to 2399
            times[i] = (times[i] + diff + 2400) % 2400; 
        }
    }
}
*/


string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}