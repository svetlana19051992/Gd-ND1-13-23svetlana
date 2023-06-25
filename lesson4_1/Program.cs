// See https://aka.ms/new-console-template for more information
using System.Collections;

ArrayList myList = new ArrayList() {2, 8, 6};
List<int> myGenericList = new List<int>() {3, 9, 7};

myList.Add(3);
myGenericList.Add(3);
Print(myList);
PrintGeneric(myGenericList);

myList.Add(5);
myGenericList.Add(5);
Print(myList);
PrintGeneric(myGenericList);

myList.RemoveAt(3);
myGenericList.RemoveAt(3);
Print(myList);
PrintGeneric(myGenericList);

myList.RemoveAt(myList.Count - 1);
myGenericList.RemoveAt(myGenericList.Count - 1);
Print(myList);
PrintGeneric(myGenericList);

myList.Sort();
myGenericList.Sort();
Print(myList);
PrintGeneric(myGenericList);
static void Print(ArrayList myArrayList)
{
    foreach(var obj in myArrayList)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}

static void PrintGeneric(List<int> myGenericList)
{
    foreach (var obj in myGenericList)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}


Console.ReadLine();