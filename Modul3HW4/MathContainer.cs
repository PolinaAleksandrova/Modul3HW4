using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class MathContainer
    {
        private int _counter = 1;
        public event MathMethods.SomeDelegate CounterIsFull;
        public void Multiply(int multiplier)
        {
            _counter *= multiplier;
            if (_counter > 200)
            {
                CounterIsFull?.Invoke(_counter / 5, _counter % 7);
            }
        }
    }
}
