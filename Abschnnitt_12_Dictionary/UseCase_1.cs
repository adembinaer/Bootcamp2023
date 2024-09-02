using System;
using System.Collections.Generic;
using System.Text;

namespace Abschnnitt_12_Dictionary
{
    public class UseCase_1
    {

        public void GetNumbersCount()
        {

            int[] numbers = new int[10] { 20, 20, 30, 30, 30, 30, 60, 90, 90, 90 };

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                numbersCount.Add(number, 1);
            }
        }


    }
}
