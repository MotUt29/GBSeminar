// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 134431
bool isPalindrom(int number)
{
    int revNumber = 0;
    int soursNumber = number;

    while (soursNumber != 0)
    {
        int pop = soursNumber % 10;
        soursNumber = soursNumber / 10;
        revNumber = (revNumber * 10) + pop;
    }
    bool isResult = revNumber == number;
    return isResult;
}
