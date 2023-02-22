// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Задайте количество элементов вашего массива:  ");
int ChisloElementov = int.Parse(Console.ReadLine());
int[] array = new int[ChisloElementov];
string FillingArray() // заполнение массива
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        array[i] = int.Parse(Console.ReadLine());
        result = result + array[i];
    }
    return result;
}
string PrintArray()  // вывод массива
{
    string result2 = "";
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write(array[i] + ", ");
    }
    return result2;
}


string arr = FillingArray();
string Print = PrintArray();