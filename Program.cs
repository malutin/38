// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArray() // функция создания массива и заполнение его случайными цифрами 
{
    double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        if (i != array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}"); // исключение запятой в конце
        }
    }
    return array;
}

double min(double[] array) // функция поиска минимального значения
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

double max(double[] array) // функция поиска максимального значения
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double[] mas = FillArray(); //создание массива
double Max = max(mas); //поиск максимального
Console.WriteLine($"Максимальное число - {Max}");
double Min = min(mas);//поиск минимального
Console.WriteLine($"Минимальное число - {Min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива - {Max - Min}");