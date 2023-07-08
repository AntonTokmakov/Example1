Console.WriteLine("Введите чисто, что бы проверить его на счетность");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Да");
} else
{
    Console.WriteLine("Нет");
}