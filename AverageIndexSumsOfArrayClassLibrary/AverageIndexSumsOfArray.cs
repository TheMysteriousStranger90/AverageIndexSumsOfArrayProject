using System;

namespace AverageIndexSumsOfArrayClassLibrary
{
    public class AverageIndexSumsOfArray
    {
        public int GetIndex(int[] array)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (array.Length < 3) throw new ArgumentException("array.Length < 3");

            var left = array[0];
            var right = SumRightElements(array);

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (left == right)
                    return i;

                left += array[i];
                right -= array[i + 1];
            }

            return -1;
        }

        private int SumRightElements(int[] array)
        {
            int sum = 0;
            for (int i = 2; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }
    }
}