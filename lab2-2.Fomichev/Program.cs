Console.WriteLine("Введите координату x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y:");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}
else
{
    Console.WriteLine("Точка не находится в четвертой четверти.");
}
