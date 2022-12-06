//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

int DataEntryNumber(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());

    return number;
}
void FindPalindrom(string b)
{
    if (b.Length == 5) 
    {
        int i = 0;
        int[] c = new int[b.Length];
        while (i < b.Length)
        {
           c[i] = int.Parse(b[i].ToString());
           i++;
        }
        if ((c[0] == c[4]) && (c[1] == c[3]))
        {
            Console.WriteLine("Введное число является палиндромом");
        }
        else
        {
            Console.WriteLine("Введное число не является палиндромом");
        }
    }
else
    {
     Console.WriteLine("Введено не пятизначное число!");
    }
}

int a = DataEntryNumber("Введите пятизначное число: ");
string b = a.ToString();

FindPalindrom(b);