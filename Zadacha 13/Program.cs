/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
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
//какую по порядку цифру выводить (3)
int b = 3;
Console.WriteLine("Введите  число:");

Console.WriteLine(FindSecondNum(CheckNumber(b), b));
