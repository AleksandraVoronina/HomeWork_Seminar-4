// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arrRand(int len)    
{
    int[] a = new int[len];
    for (int i=0; i < a.Length; i++)
    {
        a[i] = new Random().Next(0,100); 
    }
    return a;
}

void arrPrint(int[] a)    
{
    for (int i=0; i < a.Length; i++)
        Console.Write($"{a[i]} ");
    Console.WriteLine();
}

int len = 8;    
int[] arr = new int[len];

arr = arrRand(len);   
arrPrint(arr);