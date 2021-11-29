using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace совмещение_определения_переменной_делегата_с_методом
{

    class Program
    {
        delegate int MyDelegate<T>(int v1,int v2);//обобщенный делегат
        static void Main(string[] args)
        {
            MyDelegate myDelegate = delegate (int v1, int v2)//присваиваем конструкцию делегат_тело метода
              {
                  Console.WriteLine("Метод5");
                  return v1 + v2;
              };
            myDelegate(3, 4);
        }
        //static int Method5(int v1, int v2)
        //{
        //    Console.WriteLine("Method5 ");
        //    return v1 + v2;
        //}
    }
}
