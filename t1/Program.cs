// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

class Program
{
    static void Main()
    {
        int[] myArray = new int[10];
        Random rand= new Random();
        System.Console.WriteLine("Заданный массив:");

        for( int i=0; i < myArray.Length; i++)
        {
             myArray[i] = rand.Next(1, 101);
             System.Console.Write(myArray[i]+ " ");
            
        }
        System.Console.WriteLine();
        int count=0;

        foreach(int element in myArray)
        {
            if (element >=20 && element <=90)
            {
                count++;
            }
            
        }
        System.Console.WriteLine("Количество элементов  в отрезке[20;90]: " + count);
    }
}