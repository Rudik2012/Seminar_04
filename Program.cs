/* Задача 25: Напишите цикл, который принимает 
на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int raiseToDegree(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    // Console.WriteLine(result);
    return result;
}

int result = raiseToDegree(3, 5);
Console.WriteLine(result);
int result2 = raiseToDegree(2, 4);
Console.WriteLine(result2);


/* Задача 27: Напишите программу, которая 
принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12   */


int SumNumbers(int num)
{
    int sum = 0;
        
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
        
    return sum;
}
    
int num1 = 452;
int sum1 = SumNumbers(num1);
Console.WriteLine(sum1);
        
int num2 = 82;
int sum2 = SumNumbers(num2);
Console.WriteLine(sum2);
        
int num3 = 9012;
int sum3 = SumNumbers(num3);
Console.WriteLine(sum3);


/* Напишите программу, которая задаёт массив из
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]  */

void Main(int size)
{
    // Создаем массив из size-элементов
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    // Выводим элементы массива на экран
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

Console.WriteLine("введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Main(a);