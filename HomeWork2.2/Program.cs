/*Получить среднее арифметическое пяти чисел
Ввод: 5 целых чисел
Вывод: 1 число с плавающей запятой
*/

using System;

class HomeWork
{
    static void Main()
    {
        Console.WriteLine("Введите 5 целых чисел");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        int number4 = int.Parse(Console.ReadLine());
        int number5 = int.Parse(Console.ReadLine());

        float sum = number1 + number2 + number3 + number4 + number5;
        float average = sum / 5;
        Console.WriteLine("Среднее арифметическое" + average);
        Console.ReadKey();
    }
}
