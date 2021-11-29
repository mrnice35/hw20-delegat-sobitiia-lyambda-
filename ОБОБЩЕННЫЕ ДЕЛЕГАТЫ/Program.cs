using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОБОБЩЕННЫЕ_ДЕЛЕГАТЫ
{
    class Program
    {
        delegate void MyDelegate<T>(T a);//обобщенный делегат
        static void Main(string[] args)
        {
            MyDelegate<string> myDelegate = new MyDelegate<string>(Method3);
            myDelegate?.Invoke("Рудд");
            Console.ReadKey();
            
        }
        static void Method3(string name)
        {
            Console.WriteLine("Method3");
            Console.WriteLine(name);
        }
    }
}
