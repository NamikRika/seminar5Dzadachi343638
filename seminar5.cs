// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Задача 34: ---Начало--------------------------------------------------------------

Console.WriteLine("Задача 34\n Задайте массив заполненный случайными положительными трёхзначными числами.\n Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine();
Console.WriteLine("Решение");   
Console.WriteLine();

int [] CreatMyArray  (int size, int minValue, int maxValue)
{
    int[] myArray = new int [size];
    for (int i =0; i < size; i++)
    {
      myArray[i] = new Random().Next(minValue, maxValue);

    }

    return myArray;

}

int amountOfEvenNumbersInArray=0;

void ShowArray(int[] myShowArray)
{

     for(int i=0; i < myShowArray.Length; i++)
    {
       Console.Write(myShowArray[i] + " ");

       if (myShowArray[i] % 2 == 0)
       {       

          if (myShowArray[i] % 2 == 0)
            {
               amountOfEvenNumbersInArray++;                        
          
            }                
          
       }       

    }
  
    Console.WriteLine();
    Console.WriteLine("Количество чётных чисел в массиве " + amountOfEvenNumbersInArray); 
}

Console.Write("Введите размер массива ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int [] fillingArray = CreatMyArray(sizeArray, 100, 999);

ShowArray(fillingArray);

// Задача 34: ---Конец--------------------------------------------------------------