// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Random random = new Random();
int[] array = new int[12];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 10);
    Console.Write(array[i] + " ");
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }

}

Console.WriteLine("Сумма положительных элементов = " + sum);


