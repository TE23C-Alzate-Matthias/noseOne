string answering;

int gameState = 1;
int answer;
int correct = Random.Shared.Next(1, 100);

bool success;

// Console.WriteLine($"{correct}");

while (gameState == 1)
{

    Console.WriteLine("\nGissa den korrekta siffran (Mellan 1 - 100) ");
    answering = Console.ReadLine();
    success = int.TryParse(answering, out answer);

    while (success == false)
    {

        Console.WriteLine("Skirv bara siffror, försök igen!");
        answering = Console.ReadLine();
        success = int.TryParse(answering, out answer);

    }

    if (answer > correct)
    {
        Console.WriteLine("Siffran är för hög");
    }
    else if (answer < correct)
    {
        Console.WriteLine("Siffran är för låg");
    }
    else if (answer == correct)
    {
        Console.WriteLine($"Korrekt siffra! Siffran var {correct}!");
        gameState++;
    }

}

Console.WriteLine("Tryck på ENTER för att avsluta programet");
Console.ReadLine();