// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
string str = Console.ReadLine();

int a = Convert.ToInt32(str);
char ThirhDigit = str[2]; 
Console.WriteLine(ThirhDigit);