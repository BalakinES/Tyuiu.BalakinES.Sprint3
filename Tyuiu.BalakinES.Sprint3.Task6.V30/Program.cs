using Tyuiu.BalakinES.Sprint3.Task6.V30.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3 | Выполнил Балакин Е.С. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт 3                                                                *");
        Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #30                                                             *");
        Console.WriteLine("* Выполнил: Балакин Егор Сергеевич | ИБКСб-26-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Напишите программу, которая ищет среди целых чисел, принадлежащих       *");
        Console.WriteLine("* числовому отрезку [11, 17] количество всех делителей                    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int startValue = 11;
        int stopValue = 17;

        Console.WriteLine("Начало отрезка: " + startValue);
        Console.WriteLine("Конец отрезка: " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, stopValue));
        Console.ReadKey();
    }
}