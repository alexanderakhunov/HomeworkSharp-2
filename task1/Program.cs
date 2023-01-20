//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите ваше число: ");
int num = Convert.ToInt32(Console.ReadLine());
 if (num > 99 && num < 1000)
 {
    System.Console.WriteLine($"2-я цифра {num} = {num / 10 % 10}");
 }
 else
 {System.Console.WriteLine("Введите другое число");
 }