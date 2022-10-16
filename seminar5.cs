// // Задача 34: 
// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.
// // [345, 897, 568, 234] -> 2

// // Задача 34: ---Начало--------------------------------------------------------------

// Console.WriteLine("Задача 34\n Задайте массив заполненный случайными положительными трёхзначными числами.\n Напишите программу, которая покажет количество чётных чисел в массиве.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();

// int [] CreatMyArray  (int size, int minValue, int maxValue)
// {
//     int[] myArray = new int [size];
//     for (int i =0; i < size; i++)
//     {
//       myArray[i] = new Random().Next(minValue, maxValue);

//     }

//     return myArray;

// }

// int amountOfEvenNumbersInArray=0;

// void ShowArray(int[] myShowArray)
// {

//      for(int i=0; i < myShowArray.Length; i++)
//     {
//        Console.Write(myShowArray[i] + " ");

//        if (myShowArray[i] % 2 == 0)
//        {       

//           if (myShowArray[i] % 2 == 0)
//             {
//                amountOfEvenNumbersInArray++;                        
          
//             }                
          
//        }       

//     }
  
//     Console.WriteLine();
//     Console.WriteLine("Количество чётных чисел в массиве " + amountOfEvenNumbersInArray); 
// }

// Console.Write("Введите размер массива ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] fillingArray = CreatMyArray(sizeArray, 100, 999);

// ShowArray(fillingArray);

// // Задача 34: ---Конец--------------------------------------------------------------

// Задача 36: ---Начало--------------------------------------------------------------

// // Задача 36: 
// // Задайте одномерный массив, заполненный случайными числами. 
// // Найдите сумму элементов, стоящих на нечётных позициях.
// // [3, 7, 23, 12] -> 19
// // [-4, -6, 89, 6] -> 0

// Console.WriteLine("Задача 36\n Задайте одномерный массив, заполненный случайными числами.\n Найдите сумму элементов, стоящих на нечётных позициях.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();

// int [] CreatMyArray  (int size)
// {
//     int[] myArray = new int [size];
//     for (int i =0; i < size; i++)
//     {
//       myArray[i] = new Random().Next(0, size);

//     }

//     return myArray;

// }

// int sumOfElementsInOddPositions=0;

// void ShowArray(int[] myShowArray)
// {

//      for(int i=0; i < myShowArray.Length; i++)
//     {
       
//        Console.Write(myShowArray[i] + " ");

//        if (i % 2 == 1)       
//             {
//                sumOfElementsInOddPositions = sumOfElementsInOddPositions + myShowArray[i];                                  
//             }                
          
//        }      

    
  
//     Console.WriteLine();
//     Console.WriteLine("Сумма элементов, стоящих на нечётных позициях в массиве равна " + sumOfElementsInOddPositions); 
// }

// Console.Write("Введите размер массива ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());

// int [] fillingArray = CreatMyArray(sizeArray);

// ShowArray(fillingArray);

// // Задача 36: ---Конец--------------------------------------------------------------


// // Задача 38: ---Начало--------------------------------------------------------------

// // Задача 38: 
// // Задайте массив вещественных чисел. 
// // Найдите разницу между максимальным и минимальным элементов массива.
// // [3 7 22 2 78] -> 76

// Console.WriteLine("Задача 38\n Задайте массив вещественных чисел.\n Найдите разницу между максимальным и минимальным элементов массива.");
// Console.WriteLine();
// Console.WriteLine("Решение");   
// Console.WriteLine();

// int [] CreatMyArray  (int size, int minValue, int maxValue)
// {
//     int[] myArray = new int [size];
//     for (int i =0; i < size; i++)
//     {
//       myArray[i] = new Random().Next(minValue, maxValue);

//     }

//     return myArray;

// }

// int differenceBetweenMaxMinEementsArray = 0;

// void ShowArray(int[] myShowArray)
// {
//      int maxValue = 0;
//      int minValue = myShowArray[0];
     
//      for(int i=0; i < myShowArray.Length; i++)
//     {
//        Console.Write(myShowArray[i] + " ");

//        if (maxValue < myShowArray[i])
//        {  
//         maxValue = myShowArray[i];    
//        }          

//        if (minValue > myShowArray[i])
//        {  
//         minValue = myShowArray[i];    
//        }          
          
//        differenceBetweenMaxMinEementsArray = maxValue - minValue;                    
//     }
  
//     Console.WriteLine();
//     Console.WriteLine("Максимальное значение эелементов массива равно " + maxValue);
//     Console.WriteLine("Минимальное значение эелементов массива равно " + minValue);  
//     Console.WriteLine("Разность равна " + differenceBetweenMaxMinEementsArray); 
// }

// Console.Write("Введите размер массива ");
// int sizeArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальный диапазон массива ");
// int minValueArray = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальный диапазон массива ");
// int maxValueArray = Convert.ToInt32(Console.ReadLine());

// int [] fillingArray = CreatMyArray(sizeArray, minValueArray, maxValueArray);

// ShowArray(fillingArray);

// // Задача 38: ---Конец--------------------------------------------------------------
