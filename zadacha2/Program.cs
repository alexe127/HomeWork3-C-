// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число N > 0 : ");
int N = int.Parse(Console.ReadLine());

int fact = 1;

for (int i = 1; i <= N; i++)
{
    fact = fact * i;
}
Console.Write( "произведение чисел от 1 до " + N + " = " + fact);
