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
