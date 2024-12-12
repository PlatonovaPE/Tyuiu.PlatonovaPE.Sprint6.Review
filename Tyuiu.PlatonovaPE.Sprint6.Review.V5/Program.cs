﻿using Tyuiu.PlatonovaPE.Sprint5.Review.V5.Lib;
namespace Tyuiu.PlatonovaPE.Sprint5.Review.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнила: Платонова Полина Евгеньевна | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила: Выполнила: Платонова Полина Евгеньевна | ИСПб-24-1           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл, в котором есть набор символьных данных.Удалить все латинские  *");
            Console.WriteLine("* буквы из файла.Полученный результат сохранить.                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V5.txt");
            Console.WriteLine("Данныне находяться в файле: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadDataAndSave(path));
        }
    }
}