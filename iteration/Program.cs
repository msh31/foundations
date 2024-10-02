static double ConvertToCelcius(double fahrenheit) { return (5.0 / 9) * (fahrenheit - 32); }
static double ConvertToFahrenheit(double celcius) { return (celcius * 1.8) + 32; }

static void CelsiusTable(int from, int to, int step) 
{
    for (int i = from; i < to; i += step)
    {
        Console.WriteLine($"{i} degrees Fahrenheit is: {ConvertToCelcius(i):0.00} degrees Celcius");
    }
}

static void FahrenheitTable(int from, int to, int step) 
{
    for (int i = from; i < to; i += step)
    {
        Console.WriteLine($"{i} degrees Celcius is: {ConvertToFahrenheit(i):0.00} degrees Fahrenheit");
    }
}

CelsiusTable(30, 240, 10);
Console.WriteLine(string.Empty);
FahrenheitTable(0, 115, 5);