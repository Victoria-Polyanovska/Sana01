double a, b, m, n; 
double x, y, z1, z2;

Console.WriteLine("Enter a: ");
string input = Console.ReadLine();
a = double.Parse(input);

Console.WriteLine("Enter b: ");
input = Console.ReadLine();
b = double.Parse(input);

Console.WriteLine("Enter m: ");
input = Console.ReadLine();
m = double.Parse(input);

Console.WriteLine("Enter n: ");
input = Console.ReadLine();
n = double.Parse(input);

Console.WriteLine("Enter x: ");
input = Console.ReadLine();
x = double.Parse(input);

z1= ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / Math.Sqrt(Math.Pow(m, 3) * n + n * m + Math.Pow(m, 2) - m);
Console.WriteLine($"z1={z1}");

z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
Console.WriteLine($"z2={z2}");

y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Pow(Math.Sin(a - b), 2) + 0.01 * (x - b);
Console.WriteLine($"y={y}"); 