// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Random random = new Random();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0,2); 
    Console.Write(array[i] + " ");
}
