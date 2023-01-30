
























void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = object; i < array.Length - 1; i++)
    {
        Console.Write($"'{array[i]}', ");
    }
    Console.Write($"'{array[array.Length - 1]}']");
}

string[] myArray = { "death", "life", "-_-", ">_<", "3579", "123", "bom" };
PrintArray(FilterArray(myArray));
