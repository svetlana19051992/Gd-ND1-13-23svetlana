// See https://aka.ms/new-console-template for more information
using lesson4_3;
using static lesson4_3.NameObjectNameComparer;

var carCollection = new NameObjectCollection<CarObject>();
carCollection.Add(new CarObject
{
    Name = "Skoda",
    EngineCapacity = 2.0
}, StringComparer.CurrentCulture);
carCollection.Add(new CarObject
{
    Name = "Mercedes",
    EngineCapacity = 2.5
}, StringComparer.CurrentCulture);
carCollection.Add(new CarObject
{
    Name = "BMW",
    EngineCapacity = 3.5
}, StringComparer.CurrentCulture);

carCollection.OutputNamesToConsole();

carCollection.Add(new CarObject { Name = "Audi", EngineCapacity = 2.5 }, StringComparer.CurrentCulture);

carCollection.OutputNamesToConsole();