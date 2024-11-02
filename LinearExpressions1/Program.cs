double a, b, c, d;
double x, y, z, r;

Console.WriteLine("Enter a: ");
string input = Console.ReadLine();
a = double.Parse(input);

Console.WriteLine("Enter b: ");
input = Console.ReadLine();
b = double.Parse(input);

Console.WriteLine("Enter c: ");
input = Console.ReadLine();
c = double.Parse(input);

Console.WriteLine("Enter d: ");
input = Console.ReadLine();
d = double.Parse(input);

x = a + 2 * b - c + d / (c * d) + a + b / (c - d) - a * a / (b * b);
Console.WriteLine($"x={x}");

y = (5 * (a + b) * (c - d)) / (0.5 * c) + (d * d) * (a * a) - (b * b) / (b - a);
Console.WriteLine($"y={y}");

z = Math.Pow(x * x - 2 * x, 3) - 4 * (Math.Pow(x, 4) + 1) * (1 - b);
Console.WriteLine($"z={z}");

r = (1 / 2) * a + (3 / 4) * b - (7 / 5) / (3 * c + 1) + 1 / (a - c);
Console.WriteLine($"r={r}");
