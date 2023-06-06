// See https://aka.ms/new-console-template for more information
int[] ar = {0, 1, 2, 3, 5, 6, 7, 8};
for (int i=0; i<8; i++) 
   {
     Console.Write($"{ar[i]} ");
   }

Console.WriteLine();

foreach (int elem in ar)
{
    Console.Write($"{elem} ");
}