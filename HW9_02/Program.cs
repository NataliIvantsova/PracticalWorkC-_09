/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

void SumOfNatNumbers1(int start, int finish, int sum)
{
    if (start > finish)
    {
        System.Console.WriteLine($"{sum}");
        return;
    }
    else
    {
        sum = sum + ((start)++);
        SumOfNatNumbers1(start,finish,sum);
    }
}

int SumOfNatNumbers2(int start, int finish)
{
    if (finish<=start)
    {
        return start;
    }
    else
    {
        //sum = sum + ((start)++);
        return finish + SumOfNatNumbers2(start,finish-1);
    }
}

System.Console.WriteLine("1 способ ");
SumOfNatNumbers1(1, 15, 0);
System.Console.WriteLine("2 способ ");
System.Console.WriteLine(SumOfNatNumbers2(1, 15));
