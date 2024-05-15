var random = new Random();
var secretNumber = random.Next(1, 10);
//Console.WriteLine($"Det hemmelige tallet er {secretNumber}.");
var number = -1;
var guessCount = 0;

while (number != secretNumber)
{
    Console.Write("Gjett et tall: ");
    var numberStr = Console.ReadLine();
    number = Convert.ToInt32(numberStr);
    guessCount++;
    if (number != secretNumber)
    {
        var text = number < secretNumber ? "For lavt" : "For høyt";
        Console.WriteLine(text);
    }
    //if (number > secretNumber)
    //{
    //    Console.WriteLine("For høyt");
    //}
    //else if (number < secretNumber)
    //{
    //    Console.WriteLine("For lavt");
    //}
}
Console.WriteLine($"Riktig! Du brukte {guessCount} forsøk.");
