/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */
//проверка вводится ли число
int CheckNumber()
{
    string x = Console.ReadLine();
    Int32 num;
    bool isNum = Int32.TryParse(x, out num);
    if (isNum == false)
    {
        Console.WriteLine("Это не число, либо оно не целое!");
        Environment.Exit(0);
    }

    if (Math.Abs(num) /100  < 1)
    {
        Console.WriteLine("в числе меньше 3 цифр");
        Environment.Exit(0);
    }
    return Math.Abs(num);
}

int FindSecondNum(Int32 number)
{

    while (number >= 100) number /= 10;
    int d = number % 10;
    return Math.Abs(d);

}
//какую по порядку цифру выводить
Console.WriteLine("Введите  число:");
Console.WriteLine(FindSecondNum(CheckNumber()));
