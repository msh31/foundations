string oldDutch = "Hebban olla vogala nestas hagunnan hinase hic anda thu. Wat unbidan we nu?";

//store characters & counts
Dictionary<char, int> freaktionary = new Dictionary<char, int>();

foreach (char c in oldDutch.ToLower())
{
    if (freaktionary.ContainsKey(c))  { freaktionary[c]++; }
    else { freaktionary[c] = 1; } 
}

foreach (var sorted in freaktionary.OrderByDescending(sorted => sorted.Value)) { Console.WriteLine($"{sorted.Key} = {sorted.Value}"); }