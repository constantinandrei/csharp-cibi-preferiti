// See https://aka.ms/new-console-template for more information
string[] cibiPreferiti = { "Pasta", "Pizza", "Hamburger", "Lenticchie", "Zucca", "Formaggio", "Zucchine", "Arance", "Riso", "Pomodori" };


// La lunghezza della classifica

Console.WriteLine("Lunghezza classifica: " + cibiPreferiti.Length);

Console.WriteLine("--------------------------");
Console.WriteLine();

// La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)

Console.WriteLine("Classifica:");

for (int i = 0; i < cibiPreferiti.Length; i++)
{
    int numeroInClassifica = i + 1;
    Console.WriteLine(numeroInClassifica + ". " + cibiPreferiti[i]);
}

Console.WriteLine("--------------------------");
Console.WriteLine();

// Il vostro cibo top (prima posizione della classifica)

Console.WriteLine("Primo piatto in classifica:");
Console.WriteLine(cibiPreferiti[0]);

Console.WriteLine("--------------------------");
Console.WriteLine();

// Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

Console.WriteLine("Ultimo piatto in classifica (ma sempre preferito):");
Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);

Console.WriteLine("--------------------------");
Console.WriteLine();

// BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
// Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
// In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

Console.WriteLine("Bonus: ");

// stampa il valore mediano
int posizioneMediana = cibiPreferiti.Length / 2;

// se l'array ha lunghezza pari stampiamo anche la posizione precedente
if (cibiPreferiti.Length % 2 == 0)
{
    Console.WriteLine(cibiPreferiti[posizioneMediana -1 ]);
}

Console.WriteLine(cibiPreferiti[posizioneMediana]);

