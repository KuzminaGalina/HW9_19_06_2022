/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
*/

int Akkerman(int M, int N)
{
    if(M == 0)
{
    N = N+1;
}
else if(M>0 && N==0)
{
    return Akkerman(M-1, 1);
}
else if(M>0 && N>0)
{
    return Akkerman(M-1, Akkerman(M, N-1));
}
return N;
}

Console.WriteLine(Akkerman(2, 3));