// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "Pasta", "Pizza", "Hamburger", "Lenticchie", "Zucca", "Formaggio", "Zucchine", "Arance", "Riso", "Pomodori" };

Console.WriteLine("Lunghezza classifica: " + cibiPreferiti.Length);

Console.WriteLine("--------------------------");
Console.WriteLine();


Console.WriteLine("Classifica:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    int numeroInClassifica = i + 1;
    Console.WriteLine(numeroInClassifica + ". " + cibiPreferiti[i]);
}

Console.WriteLine("--------------------------");
Console.WriteLine();

Console.WriteLine("Primo piatto in classifica:");
Console.WriteLine(cibiPreferiti[0]);

Console.WriteLine("--------------------------");
Console.WriteLine();

Console.WriteLine("Ultimo piatto in classifica (ma sempre preferito):");
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);

Console.WriteLine("--------------------------");
Console.WriteLine();
Console.WriteLine("Bonus: ");

int posizioneMediana = cibiPreferiti.Length / 2;

if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine(cibiPreferiti[posizioneMediana -1 ]);
}

Console.WriteLine(cibiPreferiti[posizioneMediana]);

