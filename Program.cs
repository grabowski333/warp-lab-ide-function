double x = 4;
double result = Calculate(x);
Console.WriteLine($"f({x}) = {result}");

static double Calculate(double value)
{
    return 2 * value + 3;
}
