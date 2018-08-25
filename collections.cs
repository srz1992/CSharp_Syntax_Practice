// var names = new List<string> { "Sean", "Grace", "Denny"};
// foreach (var name in names)
// {
//     Console.Write($"Hello {name.ToUpper()}! ");
// }

// Console.WriteLine();
// names.Add("Maria");
// names.Add("Bill");
// names.Remove("Grace");

// foreach (var name in names){
//     Console.WriteLine($"Hello {name.ToUpper()}! ");
// }

// Console.WriteLine($"My name is {names[0]}.");
// Console.WriteLine($"I've added names {names[2]} and {names[3]} to the list");
// Console.WriteLine($"The list has {names.Count} people in it");

// search and sort
// var index = names.IndexOf("Sea");
// if (index != -1){
//     Console.WriteLine($"The name {names[index]} is at index {index}");
// }
// else {
// var notFound = names.IndexOf("Not Found");
//     Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
// }

// names.Sort();
// foreach(var name in names){
//     Console.WriteLine($"Hello {name.ToUpper()}! ");
// }

var fibonacciNumbers = new List<int> {1,1};

for(int counter = 0; counter<= 20; counter++){
 var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
fibonacciNumbers.Add(previous + previous2);
}

foreach(var item in fibonacciNumbers)
    Console.WriteLine($"number: {item}");