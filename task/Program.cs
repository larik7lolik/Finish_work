// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
string[]arrayA = new string[4] {"1234", "1567", "-2", "computer science"};
string[] arrayB = new string[arrayA.Length];
void First(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if(arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
        }
    }
} 

void PrintArray(string[] array)
{
    for(int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
First(arrayA, arrayB);
PrintArray(arrayB);
