// See https://aka.ms/new-console-template for more information
using Lesson5_2;

Transport myCar = new Car("Audi", 2.5);
Car myCar2 = new Car("Audi", 2.5);
Transport myBoat = new Boat("Quicksilver", 2.0);
Boat myBoat2 = new Boat("Quicksilver", 2.0);
Human myHuman = new Human();

myCar.Move();
myBoat.Move();
myCar2.Move();
myBoat2.Move();

myHuman.HumanTransport = myCar;
myHuman.ManMovesMethod();
myHuman.ChangeTransport(myBoat);
myHuman.ManMovesMethod();
myHuman.HumanTransport = myBoat2;
myHuman.ManMovesMethod();
myHuman.ChangeTransport(myCar2);
myHuman.ManMovesMethod();