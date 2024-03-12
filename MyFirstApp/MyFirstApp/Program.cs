// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfication 1");
Console.WriteLine("Modyfication 2");
Console.WriteLine("Modyfication 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }

    return (double) sum / numbers.Length;
}