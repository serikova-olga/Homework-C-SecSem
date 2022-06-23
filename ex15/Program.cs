/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.WriteLine ("input number of week day 1-7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number<6)
{
    Console.WriteLine("no");
}
else
{
    Console.WriteLine("yes");
}