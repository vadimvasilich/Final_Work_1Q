/* Написать программу, которая из имеющегося массива строк 
формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры массивов и результаты выводов
["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

// Основной метод. Ищем элементы с длинной менее 3-х символов

string[] FillArray(string[] array1, int num)
{
    string[] arr = new string[num];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        arr[count] = array1[i];
        count++;
        }
    }
    return arr;
}

// Считаем сколько слов в массиве удовлетворяют критерию отбора

int WorldsLessThan(string[] input, int n)
    {
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].Length <= 3)
            {
                count++;
            }
        }

        return count;
    }

// Выводим массив в консоль

void PrintArray(string[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
            else Console.Write($"\"{arr[i]}\"] ");
        }
    }
Console.WriteLine("Введите количество символов для отбора: ");
int number = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[5] { "hello", "2", "world", "world", ":-)" };
//string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
//string[] array1 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] array2 = new string[array1.Length];

int worldsLess = WorldsLessThan(array1, number);

PrintArray(FillArray(array1, worldsLess));