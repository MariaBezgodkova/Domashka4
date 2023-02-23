// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите ваше число");
int Chislo = int.Parse(Console.ReadLine());
int summ = 0;
void summZifr()
{
    while (Chislo > 0)
    {
        int ost = Chislo % 10;
        Chislo = Chislo / 10;
        summ = summ + ost;
    }
}
summZifr();
Console.Write("Сумма всех цифр в числе: ");
Console.WriteLine(summ);

