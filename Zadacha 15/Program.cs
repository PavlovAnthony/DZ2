/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/
//проверка вводится ли число
int CheckNumber()
{
    bool flag = false;
    Int32 num = 0;
    while (flag == false)
    {
        string x = Console.ReadLine();

        bool isNum = Int32.TryParse(x, out num);
        if (isNum == false || num < 1 || num > 7)
        {
            Console.WriteLine("Это не число, либо не соответствует заданному диапазону!");
            continue;
        }
        else flag = true;

    }
    return num;
}
Console.WriteLine("Введите номер дня недели:");

int day = CheckNumber();
if ( day== 7 || day == 6)
Console.WriteLine("это выходной");
else Console.WriteLine("тащимся на работу");