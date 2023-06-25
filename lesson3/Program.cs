// See https://aka.ms/new-console-template for more information
int[] myArray = new int[6];

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine("Enter myArray[{0}]", i);
    myArray[i] = int.Parse(Console.ReadLine());
}

Array.Sort(myArray);
Array.Reverse(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");    
}

Console.ReadLine();