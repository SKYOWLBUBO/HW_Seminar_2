// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
} 
bool ValidateNumbe(int number)
{
    if(number>100 || number<1000)
    {
        Console.WriteLine("это число трехзначное");
        return true;
    }
  return false;
}


int number = Prompt("Введите трехзначное число");
if(ValidateNumbe(number))
{
    int MiddleDigit = number / 10 % 10;
    System.Console.WriteLine($"Вторая цифра числа {number} равна {MiddleDigit}");
}











