// Задача 2: Задайте массив на 10 целых чисел.
//  Напишите программу, которая определяет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        int[] myArray = new int[10];
        Random rand= new Random();
        System.Console.WriteLine("Заданный массив:");

        for( int i=0; i < myArray.Length; i++)
        {
             myArray[i] = rand.Next();
             System.Console.Write(myArray[i]+ " ");
            
        }
        System.Console.WriteLine();
        
        
    int count = 0;

    foreach (int elements in myArray)
    {
        if (elements %2 == 0)
        {
            count++;
        }
    }
            System.Console.WriteLine("Число чётных чисел: " + count);
    }



    
    
}
    