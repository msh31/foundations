double sheepPrice = 8.0;
double chickenPrice = 3.0;
double bunnyPrice = 0.50;

int totalAnimals = 100;
double totalCash = 100.0;

int count = 0;

for (int sheep = 0; sheep <= 12; sheep++) // 100 / 8 = 12(.5)
{
    for (int chicken = 0; chicken <= 33; chicken++) // 100 / 3 = 33
    {
        int bunny = totalAnimals - sheep - chicken;

        if (bunny >= 0)
        {
            double totalPrice = (sheep * sheepPrice) + (chicken * chickenPrice) + (bunny * bunnyPrice);

            //price check, check floating point precisie 
            if (Math.Abs(totalPrice - totalCash) < 0.0001)  { Console.WriteLine($"{sheep} schapen, {chicken} kippen, {bunny} konijnen"); } 
        }

        count++;
    }
}

Console.WriteLine($"{count} mogelijkheden gecontroleerd.");