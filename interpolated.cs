// var name = "Sean";
// Console.WriteLine($"Hello, {name}. It's a pleasure to meet you");

public class Vegetable{
    public Vegetable(string name) => Name = name;

    public string Name {get;}
    
    public override string ToString() => Name;
}

// public enum Unit { item, kilogram, gram, dozen }

// var item = new Vegetable("eggplant");
// var date = DateTime.Now;
// var price = 1.99m;
// var unit = Unit.item;
// Console.WriteLine($"On {date:d}, the price of {item} was {price:C2} per {unit}.");

var inventory = new Dictionary<string, int>()
{
    ["hammer, ball pein"] = 18,
    ["hammer, cross pein"] = 5,
    ["screwdriver, Phillips #2"] = 14
};

Console.WriteLine($"Inventory on {DateTime.Now:d}");
Console.WriteLine(" ");
Console.WriteLine($"|{"Item", -25}|{"Quantity", 10}|");
foreach (var item in inventory)
    Console.WriteLine($"|{item.Key, -25}|{item.Value,10}|");