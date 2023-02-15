/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в 
промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/


void EvenNumbers(int start, int finish)
{
    if(start>finish)
    {
        return;
    }
    if (start%2==0)
    System.Console.Write(start+" ");
    EvenNumbers(start+1, finish);

}
EvenNumbers(1,11);