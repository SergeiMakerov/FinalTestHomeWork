Console.Write("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] array = new string[m];
FillingArray(m, array);
PrintArray(CreateSecondArray(array, GetSizeForSecondArray(array)));

void FillingArray(int size, string[] array)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите элемент массива: ");
        string str = Console.ReadLine();
        array[i] = str;
    }
}

int GetSizeForSecondArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] CreateSecondArray(string[] array, int count)
{
    string[] mass = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            mass[j] = array[i];
            j++;
        }
    }
    return mass;
}

void PrintArray(string[] secondArray)
{
    Console.Write("[ ");
    for (int i = 0; i < secondArray.Length; i++)
    {
        Console.Write(secondArray[i] + ", ");
    }
    Console.Write("]");
}