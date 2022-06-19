/* Задача 64: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 5; N = 1. -> "5, 4, 3, 2, 1"
M = 8; N = 4. -> "8, 7,6, 5, 4"
*/

string NaturSpektr(int M, int N)
{

if (M == N)
{
    return $"{N} ";
}
else
{
  return $"{M}, " + NaturSpektr (M-1, N);
}
}

Console.WriteLine(NaturSpektr(8, 4));