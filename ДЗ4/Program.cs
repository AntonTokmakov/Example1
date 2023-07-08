Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вывод");
for (int i = 1; i < a + 1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}