decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal is {min} to {max}");

double a = 1.0;
double b = 3.0;
Console.WriteLine(a/b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c/d);

// the M suffix is how you indicate that a constant should 
// use the decimal type

// use Math.PI for pi

double radius = 2.50;
double area = radius*radius*Math.PI;
Console.WriteLine($"The circle with a radius of {radius} has an area of {area}");