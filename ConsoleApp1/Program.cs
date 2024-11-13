using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Program;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskL31();
            TaskL32();
            Task33();


        }
        //Тумаков.Лабораторная 3 главы
        //Упражнение 3.1.  Создать перечислимый тип данных отображающий виды банковского счета(текущий и сберегательный). Создать переменную типа перечисления, присвоить ей значение и вывести это значение на печать.
        public enum AccountType
        {
            actual,
            saving
        }
        static void TaskL31()
        {
            AccountType accountType = AccountType.saving;
            Console.WriteLine($"Тип банковского счета: {accountType}");
        }
        //Упражнение 3.2. Создать структуру данных, которая хранит информацию о банковском счете – его номер, тип и баланс.Создать переменную такого типа, заполнить структуру значениями и напечатать результат.
        struct AccountInfo
        {
            /// <summary>
            /// Номер счета
            /// </summary>
            public int Number;
            /// <summary>
            /// Тип счета
            /// </summary>
            public string Type;
            /// <summary>
            /// Баланс
            /// </summary>
            public decimal Balance;
        }
        static void TaskL32()
        {
            AccountInfo account;

            // Заполнение структуры значениями
            account.Number = 1234567890;
            account.Type = "Текущий";
            account.Balance = 1000;

            // Вывод информации о банковском счете
            Console.WriteLine($"Номер счета: {account.Number}");
            Console.WriteLine($"Тип счета: {account.Type}");
            Console.WriteLine($"Баланс: {account.Balance}");
        }
        // Упражнение 3.3. Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными распечатать.
        public enum University
        {
            КГУ,
            КАИ,
            КХТИ
        }
        public struct Worker
        {
            /// <summary>
            /// Имя 
            /// </summary>
            public string Name;
            /// <summary>
            /// ВУЗ
            /// </summary>
            public University University;
        }
        static void Task33()
        {
            Worker worker;

            worker.Name = "Екатерина Владимировна";
            worker.University = University.КГУ;

            Console.WriteLine($"Имя: {worker.Name}");
            Console.WriteLine($"ВУЗ: {worker.University}");
        }
    }
}

