// See https://aka.ms/new-console-template for more information
using lesson4_2;
using static lesson4_2.NameObjectNameComparer;

var carCollection = new NameObjectCollection<CarObject>();
carCollection.Add(new CarObject
    {
        Name = "Audi",
        EngineCapacity = 2.5
    });
carCollection.Add(new CarObject
{
    Name = "BMW",
    EngineCapacity = 3.5
});
carCollection.Add(new CarObject
{
    Name = "Mercedes",
    EngineCapacity = 2.5
});

carCollection.OutputNamesToConsole();
carCollection.SortByName();
carCollection.OutputNamesToConsole();