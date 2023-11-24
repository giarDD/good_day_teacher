//  Задайте массив из вещественных чисел с ненулевой дробной частью. 
//  Найдите разницу между максимальным и минимальным элементов массива.

class Program
{
   static void Main()
{
    double [] myArray = {0.100002, 2.718, 1.618, 0.577, 4.669};
    double maximal = myArray[0];
    double minimal = myArray[0];
    System.Console.WriteLine("Заданный массив:");
    for (int i = 0; i < myArray.Length; i++)
    {
        System.Console.Write(myArray[i]+" ");
        if (myArray[i] > maximal)
        {
             maximal = myArray[i];
        }
        if (myArray[i]< minimal)
        {
            minimal = myArray[i];
        }
        
    }
    System.Console.WriteLine("");
    System.Console.WriteLine("Максимальное число: " +maximal);
    System.Console.WriteLine("Минимальное число: " +minimal);
    
    double diff= maximal - minimal;
    System.Console.WriteLine("Разница максимального и минимального значения: " + diff);

   
} 
}

