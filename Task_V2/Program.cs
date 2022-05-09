//Метод печати массива в терминал
void PrintArray(string[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"\"{array[i]}\",");
    }
    Console.WriteLine($"\"{array[array.Length-1]}\"]");
}

// Метод создания и заполнения валидного массива по условиям задачи(элементами <=3)
string[] GetValidArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] ValidArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            ValidArray[j++] = array[i];
        }
    }
    return ValidArray;
}
// Метод создания и заполнения массива пользователем
string[] CreateandFillArray(int size)
{

    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите что Вам хочется: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

Console.Write("Введите количество элементов массива:  ");
int length = Convert.ToInt32(Console.ReadLine());
string[] mas = CreateandFillArray(length);
string[] result = GetValidArray(mas);
Console.WriteLine();
PrintArray(result);