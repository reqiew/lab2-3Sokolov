Console.WriteLine("Введите вариант переменных");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x");
int x = int.Parse(Console.ReadLine());
double y = 0;

switch (n)
{
    case 1:
        {
            double a = 4.2; double b = 5.3; double c = 1.5;
            if (Math.Exp(a + b) > Math.Exp(x)) y = Math.Sin(Math.Exp(a + b) + x * x);
            else if (Math.Exp(a + b) == Math.Exp(x)) y = (1 / Math.Atan(a * b * c) + Math.Pow(x, -3));
            else if (Math.Exp(a + b) < Math.Exp(x)) y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));

        }
        ; break;
    case 2:
        {
            double a = -0.35; double b = 1.8; double c = -1.8;
            if (Math.Exp(a + b) > Math.Exp(x)) y = Math.Sin(Math.Exp(a + b) + x * x);
            else if (Math.Exp(a + b) == Math.Exp(x)) y = (1 / Math.Atan(a * b * c) + Math.Pow(x, -3));
            else if (Math.Exp(a + b) < Math.Exp(x)) y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
        }
        ; break;
    case 3:
        {
            double a = 2.8; double b = -0.6; double c = 2.0;
            if (Math.Exp(a + b) > Math.Exp(x)) y = Math.Sin(Math.Exp(a + b) + x * x);
            else if (Math.Exp(a + b) == Math.Exp(x)) y = (1 / Math.Atan(a * b * c) + Math.Pow(x, -3));
            else if (Math.Exp(a + b) < Math.Exp(x)) y = Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)));
        }
        ; break;
}
Console.WriteLine($"y={y:F2}");