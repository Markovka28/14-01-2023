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

/* решение задачи посмотрел в инетренете и до конца не понял, помогите пожалуйста с вопросом: 
я пытался возвести число с помощью цикла в цикле вот так:*/
for (int i = 1; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
      Console.WriteLine($"{Math.Pow(i, j)}");  
    }
    Console.WriteLine();
}
//но программа возводила число в степень до 10 числа, а как вывести i в степень j я так и недогадался но по моему это решение локоничнее. За ранее благодарю.