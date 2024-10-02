Random rnd = new Random();
int winningNumber = rnd.Next(1, 100); 
int guessCount = 0;

while (true) 
{
    guessCount++;

    Console.Write("Enter a number between 1 and 100: ");
    int number = Convert.ToInt32(Console.ReadLine());

    //https://www.w3schools.com/cs/cs_conditions_shorthand.php
    Console.WriteLine(number > winningNumber ? "Guess lower!" : number < winningNumber ? "Guess higher!" : "Congratulations! You guessed the number in " + guessCount + " tries.");

    if (number == winningNumber) { break; }
}