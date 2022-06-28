void StampaArray(int[] array)
{
    Console.WriteLine("\nStampa array:");
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



// Programma principale

int[] array = { 1, 2, 3 };

StampaArray(array);