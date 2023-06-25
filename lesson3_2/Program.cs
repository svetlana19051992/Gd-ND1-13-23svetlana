// See https://aka.ms/new-console-template for more information
int[,] myArray = { { 2, 4, 6 }, { 11, 9, 7 }, { 12, 14, 16 } };

for (int i = 0; i < myArray.GetLength(0); i++)
{
    int maxNumber = myArray[i, 0];

    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        if (myArray[i, j] > maxNumber)
        {
            maxNumber = myArray[i, j];
        }        
    }

    Console.WriteLine("Maximum element of the {0} row is {1}", i, maxNumber);
}

Console.ReadLine();
