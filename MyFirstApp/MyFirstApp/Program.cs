// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfication 1");
Console.WriteLine("Modyfication 2");
Console.WriteLine("Modyfication 3");

static double GetAverage(int[] numbers)
{
    int suma = 0;
    foreach (var number in numbers)
    {
        suma += number;
    }

    return (double)suma / numbers.Length;
}

static int MaxValue(int[] numbers)
    {
        int max = numbers[0]; 

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
                max = numbers[i];
        }

        return max;
    }

int[] numbers = { 1, 2, 3, 4 };
double average = GetAverage(numbers);
Console.WriteLine(average);