/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
//проверка вводится ли число
int CheckNumber(int c)
{
    string x = Console.ReadLine();
    Int32 num;
    bool isNum = Int32.TryParse(x, out num);
    if (isNum == false)
    {
        Console.WriteLine("Это не число, либо оно не целое!");
        Environment.Exit(0);
    }

    if (Math.Abs(num) / Math.Pow(10, c - 1) < 1)
    {
        Console.WriteLine("в числе меньше " + c + " цифр");
        Environment.Exit(0);
    }
    return Math.Abs(num);
}

int FindSecondNum(Int32 number, int c)
{

    while (number >= Math.Pow(10, c)) number /= 10;
    int d = number % 10;
    return Math.Abs(d);

}
//какую по порядку цифру выводить
int b = 3;
Console.WriteLine("Введите  число:");
Console.WriteLine(FindSecondNum(CheckNumber(b), b));
