static double ConvertToCelcius(double fahrenheit) { return (5.0 / 9) * (fahrenheit - 32); }
static double ConvertToFahrenheit(double celcius) { return (celcius * 1.8) + 32; }

Console.WriteLine($"30 degrees fahrenheit is: {ConvertToCelcius(30):0.00}");
Console.WriteLine($"100 degrees fahrenheit is: {ConvertToCelcius(100):0.00}");
Console.WriteLine($"230 degrees fahrenheit is: {ConvertToCelcius(230):0.00}\n");

Console.WriteLine($"30 degrees celcius is: {ConvertToFahrenheit(30):0.00}");
Console.WriteLine($"60 degrees celcius is: {ConvertToFahrenheit(60):0.00}");
Console.WriteLine($"110 degrees celcius is: {ConvertToFahrenheit(110):0.00}");