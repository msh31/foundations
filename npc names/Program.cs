Random rand = new Random(); 

string[] vowels = {"a", "e", "i", "o", "u"};
string[] consonants = {"b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "n", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z"};

string RandomVowel() { 
    int index = rand.Next(vowels.Length); 
    string vowel = vowels[index];     
    return vowel;
}

string RandomConsonant() { 
    int index = rand.Next(consonants.Length); 
    string consonant = consonants[index];     
    return consonant;
}

string MaleName()
{
    string name = RandomConsonant();

    for (int i = 0; i < 5; i++)
    {
 //if i / 2 is 0 add a vowel to the name otherwise a consonent
        if (i % 2 == 0) { name += RandomVowel(); }
        else { name += RandomConsonant(); }
    }
    return name;
}

string FemaleName()
{
    string name = RandomVowel();
    for (int i = 0; i < 5; i++)
    {
        if (i % 2 == 0) { name += RandomConsonant(); }
        else { name += RandomVowel(); }
    }
    return name;
}

void ListOfMaleNames(int amount)
{
    Console.WriteLine("Male names:");
    for (int i = 0; i < amount; i++) { Console.WriteLine($"{i + 1}. {MaleName()}"); }
}

void ListOfFemaleNames(int amount)
{
    Console.WriteLine("Female names:");
    for (int i = 0; i < amount; i++) { Console.WriteLine($"{i + 1}. {FemaleName()}"); }
}

ListOfMaleNames(10);
ListOfFemaleNames(10);