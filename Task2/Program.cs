// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число от 1 до 7: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine($"{num} это понедельник!");
}
else if (num == 2)
{
    Console.WriteLine($"{num} это вторник!");
}
else if (num == 3)
{
    Console.WriteLine($"{num} это среда!");
}
else if (num == 4)
{
    Console.WriteLine($"{num} это четверг!");
}
else if (num == 5)
{
    Console.WriteLine($"{num} это пятница!");
}
else if (num == 6)
{
    Console.WriteLine($"{num} это суббота!");
}
else if (num == 7)
{
    Console.WriteLine($"{num} это воскресенье!");
}
else if (num > 7)
{
    Console.WriteLine("Нет! Введите число меньше 7!");
}