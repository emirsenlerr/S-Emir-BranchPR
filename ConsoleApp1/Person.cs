using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person : Person2
    {
        public Person(int _yas, string _isim) : base(_isim)
        {
            Console.WriteLine($"Yaş: {_yas}");
        }
    }
}
