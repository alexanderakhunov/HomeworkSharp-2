//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите день недели : ");
int num = Convert.ToInt32(Console.ReadLine());
 if (num > 7)
 {
System.Console.WriteLine("В неделе 7 дней");
 }
 else if  (num == 1)
 {
System.Console.Write("Введенный день недели - понедельник ");
 }
 else if  (num == 2)
 {
System.Console.Write("Введенный день недели - вторник");
 }
 else if  (num == 3)
 {
System.Console.Write("Введенный день недели - среда");
 }
 else if  (num == 4)
 {
System.Console.Write("Введенный день недели - четверг");
 }
 else if  (num == 5)
 {
System.Console.Write("Введенный день недели - пятница");
 }
 else if  (num == 6)
 {
System.Console.Write("Введенный день недели - суббота");
 }
 else if  (num == 7)
 {
System.Console.Write("Введенный день недели - Воскресенье");
 }
if (num >= 6)
{
    System.Console.Write("  (выходной)");
}
else
{
    System.Console.Write("  (рабочий день)");
}