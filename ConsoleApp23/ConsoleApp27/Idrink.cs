using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Idrink
    {
        public interface IDrink<T> where T : Product
        {
            void Add(T product);
            void Sell(string name, int count);
            void Display();
            void ShowIncome();
        }
    }
}
