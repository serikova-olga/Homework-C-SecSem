﻿/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine ("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 999)
{
    int thirdDigit = number%10; 
    Console.WriteLine (thirdDigit);
}
else
{
   Console.WriteLine ("there is no third digit"); 
}
