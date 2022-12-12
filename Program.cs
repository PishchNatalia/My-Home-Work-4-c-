// Домашняя работа 4
//Задача1.Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;
for (int i = 1; i < b; i++)
{
    step = step * a;
}

Console.WriteLine(" А в степени Б равно :" + step);
*/

//Задача 2.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("Введите число:  ");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (i > 0)
{
    int num = i % 10;
    i = i / 10;
    sum = sum + num;
}
Console.WriteLine("Сумма всех чисел в числе равна:"+ sum);


 









 // Задача 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.







