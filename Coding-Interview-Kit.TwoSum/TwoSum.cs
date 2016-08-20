using System.Collections.Generic;
using System.Linq;

namespace Coding_Interview_Kit.TwoSum
{
    public class TwoSum : ITwoSum
    {

        private readonly Dictionary<int, int> _numbers;

        public TwoSum()
        {
            _numbers = new Dictionary<int, int>();
        }

        public void Add(int number)
        {
            if (_numbers.ContainsKey(number))
                _numbers[number]++;
            else
                _numbers.Add(number, 1);
        }

        public bool Find(int sum)
        {
            IEnumerable<int> numbers = GetNumbersToCheck(sum);
            foreach (var existingNumber in numbers)
            {
                long expectedNumber = (long)sum - existingNumber;
                if ((int)expectedNumber == expectedNumber)
                {
                    if (expectedNumber == existingNumber)
                    {
                        if (_numbers[existingNumber] > 1)
                            return true;
                    }
                    else if (_numbers.ContainsKey((int)expectedNumber))
                        return true;
                }
            }
            return false;
        }

        private IEnumerable<int> GetNumbersToCheck(int sum)
        {
            IEnumerable<int> numbers;
            if (sum < 0)
                numbers = _numbers.Keys.Where(number => number > sum);
            else
                numbers = _numbers.Keys.Where(number => number <= sum);
            return numbers;
        }

    }
}
