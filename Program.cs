// See https://aka.ms/new-console-template for more information
//string[] cibiPreferiti = { "Pasta", "Pizza", "Hamburger", "Lenticchie", "Zucca", "Formaggio", "Zucchine", "Arance", "Riso", "Pomodori" };


//// La lunghezza della classifica

//Console.WriteLine("Lunghezza classifica: " + cibiPreferiti.Length);

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)

//Console.WriteLine("Classifica:");

//for (int i = 0; i < cibiPreferiti.Length; i++)
//{
//    int numeroInClassifica = i + 1;
//    Console.WriteLine(numeroInClassifica + ". " + cibiPreferiti[i]);
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Il vostro cibo top (prima posizione della classifica)

//Console.WriteLine("Primo piatto in classifica:");
//Console.WriteLine(cibiPreferiti[0]);

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Il vostro cibo preferito ma non troppo (ultima posizione della classifica)

//Console.WriteLine("Ultimo piatto in classifica (ma sempre preferito):");
//Console.WriteLine(cibiPreferiti[cibiPreferiti.Length - 1]);

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
//// Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
//// In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.

//Console.WriteLine("Bonus: ");

//// stampa il valore mediano
//int posizioneMediana = cibiPreferiti.Length / 2;

//// se l'array ha lunghezza pari stampiamo anche la posizione precedente
//if (cibiPreferiti.Length % 2 == 0)
//{
//    Console.WriteLine(cibiPreferiti[posizioneMediana -1 ]);
//}

//Console.WriteLine(cibiPreferiti[posizioneMediana]);

//Console.WriteLine("--------------------------");
//Console.WriteLine();


//// Snack1.  L’utente inserisce due numeri in successione.
////          Il software stampa il maggiore

//Console.WriteLine("Snack 1");
//Console.WriteLine();

//Console.WriteLine("Inserire il primo numero: ");
//int numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserire il secondo numero: ");
//int numero2 = Convert.ToInt32(Console.ReadLine());

//if (numero1 > numero2)
//{
//    Console.WriteLine($"Il primo numero ({numero1}) è più grande del secondo numero ({numero2})");

//} else if (numero2 > numero1)
//{
//    Console.WriteLine($"Il secondo numero ({numero2}) è più grande del primo numero ({numero1})");
//} else
//{
//    Console.WriteLine($"I numeri inseriti ({numero2}, {numero1}) sono uguali");
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack2.  L’utente inserisce due parole in successione.
////          Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Snack 2");
//Console.WriteLine();

//Console.WriteLine("Inserire la prima parola: ");
//string stringa1 = Console.ReadLine();

//Console.WriteLine("Inserire la seconda parola: ");
//string stringa2 = Console.ReadLine();


//if (stringa1.Length > stringa2.Length)
//{
//    Console.WriteLine($"La prima parola ({stringa1}), lunga {stringa1.Length} caratteri è più lunga della seconda parola ({stringa1}), lunga {stringa1.Length} caratteri.");
//} else if (stringa2.Length > stringa1.Length)
//{
//    Console.WriteLine($"La seconda parola ({stringa2}), lunga {stringa2.Length} caratteri è più lunga della prima parola ({stringa2}), lunga {stringa1.Length} caratteri.");
//} else
//{
//    Console.WriteLine($"Le due parole inserite ({stringa1}, {stringa2}) hanno la stessa lunghezza di {stringa1.Length} caratteri");
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
////         Il programma stampa la somma di tutti i numeri inseriti

//Console.WriteLine("Snack 3");
//Console.WriteLine();

//int somma = 0;
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"Inserisci un numero ({i + 1} / 10)");
//    somma += Convert.ToInt32(Console.ReadLine());
//}

//Console.WriteLine("La somma dei numeri inseriti è: " + somma);

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack4. Calcola la somma e la media dei numeri da 2 a 10.

//Console.WriteLine("Snack 4");
//Console.WriteLine();

//int somma2to10 = 0;
//int cicli2to10 = 0;

//for(int i = 2; i <= 10; i++)
//{
//    somma2to10 += i;
//    cicli2to10++;
//}

//Console.WriteLine($"La somma dei numeri tra 2 e 10 è {somma2to10}");
//Console.WriteLine($"La media dei numeri tra 2 e 10 è {somma2to10 / cicli2to10}");

//Console.WriteLine("--------------------------");
//Console.WriteLine();

////Snack5.  Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
////         stampa il numero, se è dispari, stampa il numero successivo.

//Console.WriteLine("Snack 5");
//Console.WriteLine();

//Console.WriteLine("Inserire un numero, se è dispari verà stampato, se è dispari verrà stampato quello successivo");

//int numeroPariDispari = Convert.ToInt32(Console.ReadLine());

//if (numeroPariDispari % 2 == 1)
//{
//    numeroPariDispari++;
//}

//Console.WriteLine(numeroPariDispari);

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
////         Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa

//Console.WriteLine("Snack 6");
//Console.WriteLine();

//string[] invitatiGatsby = { "Andrei", "Paolo", "Francesca", "Ferdinando", "paolo" };

//Console.WriteLine("Inserisci il tuo nome per controllare la lista degli invitati (Paolo è sempre benevenuto)");

//string invitato = Console.ReadLine();
//bool isInvited = false;

//for (int i = 0; i < invitatiGatsby.Length; i++)
//{
//    if (invitatiGatsby[i] == invitato)
//    {
//        isInvited = true;
//    }
//}

//if (isInvited)
//{
//    Console.WriteLine($"Benvenuto {invitato}, addesso che sei arrivato possiamo iniziare la festa!");
//} else
//{
//    Console.WriteLine($"Torni a casa sua {invitato}");
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack7. Crea un array vuoto.
////         Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array

//Console.WriteLine("Snack 7");
//Console.WriteLine();

//int[] arrayVuoto = new int[6];

//for (int i = 0; i < arrayVuoto.Length; i++)
//{
//    Console.WriteLine($"Inserisci un numero ({i + 1} / 6), se è dispari verrà stampato nella lista finale");
//    int numero = Convert.ToInt32(Console.ReadLine());

//    if (numero % 2 == 1)
//    {
//        arrayVuoto[i] = numero;
//    }
//}

//Console.WriteLine();
//Console.WriteLine("I numeri dispari sono:");

//for (int i = 0; i < arrayVuoto.Length; i++)
//{
//    if (arrayVuoto[i] != 0)
//    {
//        Console.WriteLine(arrayVuoto[i]);
//    }
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

////Snack8.  Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
////         posizione dispari.

//Console.WriteLine("Snack 8");
//Console.WriteLine();

//int[] numeriInteri = { 2, 4, 8, 87, 34, 12, 4, 2, 56 };
//int sommaPosizioneDispari = 0;

//Console.WriteLine("L'array dei numeri è:");

//for (int i = 0; i < numeriInteri.Length; i++)
//{
//    Console.Write($"Posizione: {i}, valore: {numeriInteri[i]}");
//    Console.WriteLine();
//    if (i % 2 == 1)
//    {
//        sommaPosizioneDispari += numeriInteri[i];
//    }
//}


//Console.WriteLine();
//Console.WriteLine($"la somma dei numeri in posizione dispari è: {sommaPosizioneDispari}");

//Console.WriteLine("--------------------------");
//Console.WriteLine();

//// Snack9.  Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
////          Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
////          somma degli elementi è minore di 50.

//Console.WriteLine("Snack 9");
//Console.WriteLine();

//int[] array50 = new int[50];
//int somma50 = 0;
//int cicloArray50 = 0;

//while (somma50 < 50)
//{
//    Console.WriteLine($"Inserisci un numero, per adesso la somma è {somma50}");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    if (numero > 0)
//    {
//        array50[cicloArray50] = numero;
//        somma50 += numero;
//        cicloArray50++;
//    }

//    if (somma50 > 50)
//    {
//        Console.WriteLine("abbiamo superato 50!");
//    }
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();

// Snack10.  Fai inserire un numero, che chiameremo N, all’utente.
//           Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//           Ogni volta che ne crei uno, stampalo a schermo

//Console.WriteLine("Snack 10");
//Console.WriteLine();


//Console.WriteLine("Quanti array creare?");
//int numeroN = Convert.ToInt32(Console.ReadLine());

//for(int i = 0; i < numeroN; i++)
//{
//    int[] arrayN = new int[10];

//    for (int j = 0; j < arrayN.Length; j++)
//    {
//        Random random = new Random();
//        arrayN[j] = random.Next(1, 100);
//    }

//    for (int k = 0; k < arrayN.Length; k++)
//    {
//        if (k < arrayN.Length - 1)
//        {
//            Console.Write(arrayN[k] + " - ");
//        } else
//        {
//            Console.Write(arrayN[k]);
//        }
//    }

//    Console.WriteLine();
//}

//Console.WriteLine("--------------------------");
//Console.WriteLine();


// Funzioni

//Snack 1
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due. (stampare fuori dalla funzione)

string CompareWord(string firstWord, string secondWord)
{
    if (firstWord.Length == secondWord.Length)
        return firstWord + " " + secondWord;
    else if (firstWord.Length > secondWord.Length)
        return firstWord;
    else
        return secondWord;
}

Console.WriteLine("Inserire la prima parola");
string firstWord = Console.ReadLine();

Console.WriteLine("Inserire la seconda parola");
string secondWord = Console.ReadLine();

Console.WriteLine(CompareWord(firstWord, secondWord));

//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.

string OddEven(int number)
{
    if (number % 2 == 0)
        return "pari";
    else
        return "dispari";
}

Console.WriteLine("Inserisci il numero per sapere se e pari oppure dispari");
int oddEvenNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il numero inserito è {OddEven(oddEvenNumber)}");