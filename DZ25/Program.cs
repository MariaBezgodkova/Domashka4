// Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// Math.Pow использовать нельзя
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


string StepenA(int A, int B)
{
    string result = "";
    int newA = 1;
    for (int i = 1; i <= B; i++)
    {
        newA = newA * A;
    }
    result = result + newA;
    return result;
}

Console.WriteLine("Введите два натуральных числа:");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
string newA2 = StepenA(A, B);
Console.WriteLine(" число A в степени В равно:");
Console.WriteLine(newA2);