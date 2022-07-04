// **Задача**: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// **Примеры**:

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] CutArrayByChar(string[] array, int charcut)
{
    int len = array.Length;
    int j = 0;
    string[] tempArray = new string[len];
    for (int i = 0; i < len; i++)
    {
        int txtsize = array[i].Length;
        if (txtsize <= charcut)
        {
            tempArray[j] = array[i];
            j++;
        }
    }

    // реализация изменения размера массива без вложенных методов.
    // печать массива PrintArray не будет печатать пустой строчный элемент, 
    // но размер массива нового не будет соответствовать реальному количествую новых элементов.


    string[] newArray = new string[j];
    for (int i = 0; i < j; i++)
    {
        newArray[i]=tempArray[i];
        Console.WriteLine(i);
    }
    return newArray;
}




Console.WriteLine("Задайте эл-ты массива через пробел");
string[] txt = Console.ReadLine().Split(' ').ToArray();


string[] newTxt = CutArrayByChar(txt, 3);
PrintArray(newTxt);
Console.WriteLine(newTxt.Length);


// // 4 5 6 8 9 5
// int[] numsArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

// Console.WriteLine(string.Join(' ', numsArr));