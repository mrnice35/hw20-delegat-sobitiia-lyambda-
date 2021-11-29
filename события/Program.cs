using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace события
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank(1000);//начальная сумма
            bank.Notify += Log;//добавляем подписчика на событие(в переменную делегата добавляем ссылку на метод)
            bank.Put(1000);//положили деньги
            bank.Get(500);//сняли деньги
            Console.ReadKey();
        }
        static void Log(string message)//создаем метод(количество и тип аргументов и выходного значения должны соответствовать делегату)
        {
            Console.WriteLine(message);
        }
    }
    class Bank
    {
        public delegate void LogDelegate(string message);//создаем делегат для события
        public event LogDelegate Notify;//объявляем событие ключ слово event_тип делегата_название (событие-переменная делегата)
        private int Summa;
        public Bank(int Summa)
        {
            this.Summa = Summa;
        }
        public void Put(int S)
        {
            Summa += S;
            Notify?.Invoke($"Пополнение. Баланс {Summa}");//в момент уведомления события вызываем метод связанный с делегатами(знак вопроса-проверка на ноль)
        }
        public void Get(int S)
        {
            Summa -= S;
            Notify?.Invoke($"Списание. Баланс {Summa}");
        }
    }
}
