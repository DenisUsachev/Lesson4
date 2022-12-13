/*Задача 28: Напишите программу, которая принимает на вход число
 N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите число больше 0");
        }
    }
    return result;
}

long GetSumm(int number)
{
    long summ = 1;

    for (int i = 1; i <= number; i++)
    {
        summ *= i;
    }
    return summ;
}



int number = GetNumber("Введите число больше 0");
long summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от {number} = {summ}");