/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


int Sum(int M, int N)
{
   int result = M;
    if(M == N)
    {
        return result;
    }
    else
    {
        return result += Sum(M+1, N);
    }
}
Console.WriteLine(Sum(4, 8));