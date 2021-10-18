using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class MathMethods
    {
        private int _sumCallsCount = 0;
        private List<int> _results = new List<int>();
        public delegate int SomeDelegate(int value1, int value2);
        public int InternalSum(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Sum(int value1, int value2)
        {
            return SafeDelegateCall(InternalSum, value1, value2);
        }

        private int SafeDelegateCall(SomeDelegate sum, int value1, int value2)
        {
            _sumCallsCount++;
            try
            {
                int result = sum.Invoke(value1, value2);
                _results.Add(result);
                return result;
            }
            catch
            {
                throw new ArgumentException();
            }
        }
    }
}
