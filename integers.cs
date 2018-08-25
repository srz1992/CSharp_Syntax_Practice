int a = 18;
int b = 6;
int c = 2;
int d = (a + b) * c;
int e = (a + b) % c;

int max = int.MaxValue;
int min = int.MinValue;

Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}");