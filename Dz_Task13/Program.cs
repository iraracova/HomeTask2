// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number); //Модуль числа(учитывает число и со знаком + и со знаком -)
if(number < 99)
 {
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(number > 999)
    {
        number = number / 10;
    }
    Console.WriteLine(number % 10);
}