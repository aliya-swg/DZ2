using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            
      
              
        }
        //1. Выведите на экран информацию о каждом типе данных в виде:  Тип данных – максимальное значение – минимальное значение
        static void Task1()
        {
            // Целочисленные типы данных
            Console.WriteLine("Тип данных - Максимальное значение - Минимальное значение");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");

            // Числа с плавающей точкой
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");

            // Символьный тип данных
            Console.WriteLine($"char - {char.MaxValue} - {char.MinValue}");

            // Логический тип данных
            Console.WriteLine($"bool - {bool.TrueString} - {bool.FalseString}");
        }
        //2. Напишите программу, в которой принимаются данные пользователя в виде имени,рода, возраста и PIN-кода.Далее сохраните все значение в соответствующей еременной, а затем распечатайте всю информацию в правильном формате
        struct Data
        {
            /// <summary>
            /// имя
            /// </summary>
            public string Name;
            /// <summary>
            /// город
            /// </summary>
            public string City;
            /// <summary>
            /// возраст
            /// </summary>
            public int Age;
            /// <summary>
            /// пин-код
            /// </summary>
            public int PIN;
        }
        static void Task2()
        {
            Data personalData;
            Console.Write("введите свое имя: ");
            personalData.Name = Console.ReadLine();
            Console.Write("введите свой город: ");
            personalData.City = Console.ReadLine();
            Console.Write("введите свой возраст: ");
            personalData.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите свой пин-код: ");
            personalData.PIN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("имя: " + personalData.Name);
            Console.WriteLine("город: " + personalData.City);
            Console.WriteLine("возраст: " + personalData.Age);
            Console.WriteLine("пин-код: " + personalData.PIN);
        }
        //3. Преобразуйте входную строку: строчные буквы замените на заглавные, заглавные – на строчные
        static void Task3()
        {
            // Ввод входной строки
            Console.WriteLine("Введите строку:");
            string inputString = Console.ReadLine();

            // Преобразование регистра букв
            string outputString = "";
            foreach (char character in inputString)
            {
                if (char.IsUpper(character))
                {
                    outputString += char.ToLower(character);
                }
                else if (char.IsLower(character))
                {
                    outputString += char.ToUpper(character);
                }
                else
                {
                    outputString += character; // Сохранение небуквенных символов
                }
            }

            // Вывод преобразованной строки
            Console.WriteLine($"Преобразованная строка: {outputString}");
        }
        //4. Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран
        static void Task4()
        {
            // Ввод строки и подстроки
            Console.WriteLine("Введите строку:");
            string строка = Console.ReadLine();

            Console.WriteLine("Введите подстроку:");
            string подстрока = Console.ReadLine();

            // Подсчет количества вхождений
            int count = 0;
            int index = 0;
            while ((index = строка.IndexOf(подстрока, index)) != -1)
            {
                count++;
                index += подстрока.Length;
            }

            Console.WriteLine($"Количество вхождений подстроки: {count}");
        }
    }
}
