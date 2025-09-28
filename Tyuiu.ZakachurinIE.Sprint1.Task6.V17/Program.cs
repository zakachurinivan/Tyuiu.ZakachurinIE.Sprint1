﻿using Tyuiu.ZakachurinIE.Sprint1.Task6.V17.Lib;

namespace Tyuiu.ZakachurinIE.Sprint1.Task6.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт # 1 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Варинат #17                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что строка является перевертышем.                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            
            Console.WriteLine("Введите строку = ");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string s = Console.ReadLine();
            Console.WriteLine(ds.CheckPalindrome(s));
        }
    }
}