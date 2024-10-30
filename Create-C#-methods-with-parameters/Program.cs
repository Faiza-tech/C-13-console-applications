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

