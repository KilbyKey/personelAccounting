using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace personelAccounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] surnames = new string[0];
            string[] jobs = new string[0];
            bool inProgres = true;

            while (inProgres)
            {
                allChoise(surnames, jobs);
                Console.WriteLine("До свидание!");
                Console.ReadKey();
                inProgres = false;
            }
        }

        static string[] addAnElement(string[] array, string info)
        {
            string[] tampArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tampArray[i] = array[i];
            }
            tampArray[tampArray.Length - 1] = info;
            array = tampArray;
            return array;
        }

        static void printAllInfo(string[] surname, string[] job)
        {
            for (int i = 0; i < surname.Length; i++)
            {
                Console.Write($"{i + 1}. Фамилия - {surname[i]}, должность {job[i]};\n");
            }
        }

        static void allChoise(string[] surname, string[] job)
        {
            int userInput;
            bool inProgres = true;

            while (inProgres)
            {
                Console.Write($"\nЧто вы хотите выбрать: \n" +
                    "1. Добавить досье; \n" +
                    "2. Показать все досье; \n" +
                    "3. Удалить досье; \n" +
                    "4. Поиск по Фамилии; \n" +
                    "5. Выход");
                Console.WriteLine();

                userInput = Convert.ToInt32(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.Write("Введите фамилию: ");
                        addAnElement(surname, Console.ReadLine());
                        Console.Write("Введите должность: ");
                        addAnElement(job, Console.ReadLine());
                        printAllInfo(surname, job);
                        break;
                    case 2:
                        Console.WriteLine("Список сотрудников: ");
                        printAllInfo(surname, job);
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        inProgres = false;
                        break;
                }
            }

        }

    }
}
