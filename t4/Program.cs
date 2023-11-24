// Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Р
// Размер массива должен быть равен количеству цифр.

class Program
{
    static void Main()
    {
        Random rand= new Random();
        int number = rand.Next(1, 100001);
        System.Console.WriteLine("Заданное число: "+ number);
        int numberOfDigits = (int)Math.Log10(number) + 1;
        
        int[] digitsArray = new int[numberOfDigits];

        for (int i = 0; i < numberOfDigits; i++)
        {
            digitsArray[i] = number % 10;
            number /= 10;
        }

        Console.WriteLine("Массив цифр числа в обратном порядке:");

        foreach (int digit in digitsArray)
        {
            Console.Write(digit + " ");
        }

        Console.WriteLine();
    }
}