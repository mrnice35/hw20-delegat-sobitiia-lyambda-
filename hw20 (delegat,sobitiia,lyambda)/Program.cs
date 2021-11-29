using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw20__delegat_sobitiia_lyambda_
{
    class Program
    {
      ///delegate void MyDelegate(); //ключевое слово delegate потом тип возвращаюего элемента,название и параметры
        delegate int MyDelegate(int a,int b);//делегат принимает два целочисленных значения
        static void Main(string[] args)
        {
            /* MyDelegate myDelegate = Method2;//объявлем переменную делегата и нрисваиваем ей метод
             myDelegate += Method1;//добавляем обе ссылки в переменную делегата
             myDelegate -= Method1;//можно удалять ссылки из переменной
            myDelegate -= Method2;
             if (myDelegate!= null)//Обязательная проверка для избежания исключений
                 myDelegate();

             myDelegate();*/

            MyDelegate myDelegate = Method5;
            //при вызове делегата передаем ему аргументы
            myDelegate (3, 4);
            //результат делегаты мы можем присвоить в переменную соответствующего типа
            if (myDelegate != null)
            {
                int r = myDelegate(3, 4);

                //Втоой способ записи
                /*
                MyDelegate myDelegate=new MyDelegate(Method5);
                myDelegate?.Invoke(3,4);//ПРОВЕРКА НА НОЛЬ  

                */
                Console.WriteLine(r);
            }
                Console.ReadKey();
        }
        static void Method1()
        {
            Console.WriteLine("Method1");
        }
        static void Method2()
        {
            Console.WriteLine("Method2 ");
        }
        static int Method5(int v1,int v2)
        {
            Console.WriteLine("Method5 ");
            return v1 + v2;
        }
    }
}
