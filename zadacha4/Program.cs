// Подсчитать сумму цифр в числе
int num =  int.Parse(Console.ReadLine());
int i = num;
int sum = 0;
while (i > 0)
{
    
    sum = sum + num % 10;
    
}

Console.WriteLine(" " + sum);
