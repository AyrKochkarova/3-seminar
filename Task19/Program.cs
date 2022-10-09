// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 10000 || number > 99999)
{
    Console.WriteLine("Вы ввели недопустимое число! Пожалуйста, введите пятизначное число:");
    number = Convert.ToInt32(Console.ReadLine());
}

string result = Palindrome(number);
Console.WriteLine(result);

string Palindrome(int num)
{
    int firstNum = num / 10000;
    int secondNum = num / 1000 % 10;
    int fourthNum = num / 10 % 10;
    int fifthNum = num % 10;

    return firstNum == fifthNum && secondNum == fourthNum ? $"Число {num} является полиндромом"
                                                          : $"Число {num} не является полиндромом";

}