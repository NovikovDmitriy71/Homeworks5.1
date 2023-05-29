// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// int[] GrateRandomArray(int size)
// {
// int[]newArray=new int[size];
//   for (int i=0; i<size;i ++)
//     {
//          newArray[i]=new Random().Next(100, 1000);
//     }
//     return newArray;
// }
// void PrintArray(int[] array)
// {
//     int count=0;
//     for(int i=0;i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     } 
//     Console.WriteLine();
// }
// void evenNum(int[] array)
// {
//    int count=0;
//    for (int i=0; i<array.Length; i++)
//    {
//     if (array[i]%2==0) count++;
//    }
//    Console.WriteLine($"{count}");
// } 
// Console.WriteLine("Input size");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = GrateRandomArray(size);
//  PrintArray(myArray);
// evenNum(myArray);
//  Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
// int[] GrateRandomArray(int size,int min, int max)
// {
// int[]newArray=new int[size];
//   for (int i=0; i<size;i ++)
//     {
//          newArray[i]=new Random().Next(min, max);
//     }
//     return newArray;
// }
// void PrintArray(int[] array)
// {
    
//     for(int i=0;i<array.Length; i++)
//     {
//         Console.Write(array[i]+" ");
//     } 
//     Console.WriteLine();
// }
// void SumNoEven(int[] array)
// {
//    int sumNam=0;
//    for (int i=0; i<array.Length; i++)
//    {
//     if (i%2!=0) sumNam+=array[i]; 
//    }
//    Console.WriteLine($"{sumNam}");
// } 
// Console.WriteLine("Input size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = GrateRandomArray(size,min,max);
//  PrintArray(myArray);
// SumNoEven(myArray);



int[] GrateRandomArray(int size,int min, int max)
{
int[]newArray=new int[size];
  for (int i=0; i<size;i ++)
    {
         newArray[i]=new Random().Next(min, max);
    }
    return newArray;
}
void PrintArray(int[] array)
{
    
    for(int i=0;i<array.Length; i++)
    {
        Console.Write(array[i]+" ");
    } 
    Console.WriteLine();
}
void RazMaxMin(int[] array)
{
   int max=array[0];
   int min=array[0];
   for (int i=0; i<array.Length; i++)
   {
    if (max<array[i]) max=array[i]; 
    if (min>array[i]) min=array[i];
   }
   Console.WriteLine($"Max={max}, Min={min},  Разница = {max-min}");
} 
Console.WriteLine("Input size");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = GrateRandomArray(size,min,max);
 PrintArray(myArray);
RazMaxMin(myArray);
