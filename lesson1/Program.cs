// See https://aka.ms/new-console-template for more information
for (int i = 10; i < 100; i++) {
    if (i % 5 == 0)
        Console.Write(i + " ");
}

Console.WriteLine();
int number = -20;
do {    
    Console.WriteLine(number);
    number -= 20;
} while (number >= -100);

Console.WriteLine("Input character");
var symbol = Console.ReadLine();
switch (symbol){
    case "w" :
        Console.WriteLine("Move the shape to the up.");
        break;
    case "s" :
        Console.WriteLine("Move the shape to the down.");
        break;
    case "a" :
        Console.WriteLine("Move the shape to the right.");
        break;
    case "d" :
        Console.WriteLine("Move the shape to the left.");
        break;
    default :
        Console.WriteLine("The figure does not need to be moved.");
        break;    
}
