// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символам.


string[] FilterArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length<=3)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
         if(array[i].Length<=3)
         {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}
