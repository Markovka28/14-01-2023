// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] arr = Elements(8); 
Console.WriteLine($" [ {String.Join(" | ", arr)} ] "); 
int[] Elements(int size) 
{     
    int[] result = new int[size];     
    for (int i = 0; i < size; i++)    
    {         
        result[i] = new Random().Next(1000);    
    }     
return result;
}

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a>=1 && a<=9999)
{
Console.WriteLine($"Сумма цифр составляющих число {a} равна {(a/1000) + ((a/100)%10) + ((a/10)%10) + (a%10)}");
}
else if (a<1 || a>=9999)
Console.WriteLine($"эта программа работает только с 4х значными числами");

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B.

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int c = a;

for (int i = 1; i < b; i++)
{
    c *= a;
}
Console.WriteLine("A в степени B = " + c);