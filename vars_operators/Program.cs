Console.Write("Enter the radius of a circle: ");

//Calculations 
double radius = Convert.ToDouble(Console.ReadLine());
double diameter = radius * 2; 
float circumference = (float)(Math.PI * diameter); 
float area = (float)(radius * radius * Math.PI);
double SphereArea = 4 * Math.PI * Math.Pow(radius, 2);
double SphereVolume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

//Output
Console.WriteLine("Radius: " + radius);
Console.WriteLine("Diameter: " + diameter);
Console.WriteLine("Circumference: " + circumference);
Console.WriteLine("Area: " + area);
Console.WriteLine("Sphere area: " + SphereArea);
Console.WriteLine("Sphere volume: " + SphereVolume);

Console.ReadKey();
Environment.Exit(0);