// Найти кубы чисел от 1 до N
Console.Write("Введите число N > 0 : ");
int N = int.Parse(Console.ReadLine());


for (int i = 1; i <= N; i++)
{
   Console.Write( i * i * i + " ");
}

