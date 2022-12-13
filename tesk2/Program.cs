/*Задача 26: Напишите программу, которая принимает на вход число и 
выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный вводю Введите число больше 0.");
        }
    }

    return result;
}

int GetCount(int number)
{
    int count = 0;

    while (number > 0)
    {
        count += 1;
        number /= 10;
    }

    return count;
}


int number = GetNumber("Введите число больше 0");
int count = GetCount(number);

Console.WriteLine($"Количество чисел в числе {number}, {count}");