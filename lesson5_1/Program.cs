// See https://aka.ms/new-console-template for more information
using Lesson5_1;

Transport myCar = new Car("Audi", 2.5);
Car myCar2 = new Car("Audi", 2.5);
Transport myBoat = new Boat("Quicksilver", 2.0);
Boat myBoat2 = new Boat("Quicksilver", 2.0);
Human myHuman = new Human("Legs", 0.0, myCar);

myCar.Move();
myBoat.Move();
myCar2.Move();
myBoat2.Move();
myHuman.ManMovesMethod(myCar);
myHuman.ManMovesMethod(myBoat);
myHuman.HumanTransport = myCar;
myHuman.ShowChangeProperty();
myHuman.HumanTransport = myBoat;
myHuman.ShowChangeProperty();