// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите ваше число: ");
string num = Console.ReadLine();
 int length = num.Length;
 if (length > 2)
 {
   System.Console.WriteLine($"{num[2]}");
   
 }
 else
{ 
    System.Console.WriteLine("В числе меньше 3-х цифр ");
}