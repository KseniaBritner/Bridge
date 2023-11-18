using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Condition : RemoteImplementor
    {
        public void On()
        {
            Console.WriteLine("Кондиционер включен");
        }
        public void Off()
        {
            Console.WriteLine("Кондиционер выключен");
        }
        public void SetPower(int power)
        {
            Console.WriteLine($"Мощность кондиционера: {power}");
        }
        public void SetMode(int mode)
        {
            Console.WriteLine($"Режим: {mode}.");
        }
    }
}
