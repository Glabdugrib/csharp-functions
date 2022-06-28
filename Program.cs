void StampaArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if(i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }

    Console.WriteLine("]");
}


int Quadrato(int num)
{
    return num * num;
}


int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayQuadrato = new int[array.Length];
    
    for(int i = 0; i < array.Length; i++)
    {
        arrayQuadrato[i] = Quadrato(array[i]);
    }

    return arrayQuadrato;
}


int sommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}


// Programma principale

//int[] array = { 2, 6, 7, 5, 3, 9 }; // array fornito nella consegna

Console.Write($"\nInserisci la lunghezza dell'array: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arrayLength];

Console.WriteLine($"\nInserisci {arrayLength} numeri:");
for(int i = 0; i < arrayLength; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nArray originale:");
StampaArray(array);

//Console.WriteLine(Quadrato(2));

int[] arrayQuadrato = ElevaArrayAlQuadrato(array);

Console.WriteLine("\nArray al quadrato:");
StampaArray(arrayQuadrato);

Console.WriteLine("\nArray originale:");
StampaArray(array);

Console.Write("\nSomma array originale: ");
Console.WriteLine(sommaElementiArray(array));

Console.Write("\nSomma array al quadrato: ");
Console.WriteLine(sommaElementiArray(arrayQuadrato));