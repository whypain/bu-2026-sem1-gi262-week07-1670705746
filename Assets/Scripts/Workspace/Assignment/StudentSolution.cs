using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture

        public int LCT01_SequentialSearch1DArray()
        {
            int[] array = new int[] { 34, 21, 56, 12, 78, 90, 11, 23 };
            int target = 90;
            int index = -1;

            // Your code here ...
            // ...


            return index;
        }

        public int[] LCT02_SequentialSearch2DArray()
        {
            int[,] array = new int[,]
            {
                { 34, 21, 56 },
                { 12, 78, 90 },
                { 11, 23, 45 }
            };
            int target = 23;
            int row = -1;
            int col = -1;

            // Your code here ...
            // ...

            return new[] { row, col };
        }

        public int LCT03_BinarySearch()
        {
            int[] array = new int[] { 11, 12, 21, 23, 34, 45, 56, 78, 90 };
            int target = 23;
            int index = -1;

            // Your code here ...
            // ...

            return index;
        }

        #endregion

        #region Assignment

        public int[] AS01_FindFirstAndLastElementOfArray(int[] array, int target)
        {
            if (array == null || array.Length == 0 || !array.Contains(target))
            {
                return new[] { -1 };
            }

            int first = -1;
            int last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    if (first == -1)
                    {
                        first = i;
                    }
                    last = i;
                }
            }

            return new[] { first, last };
        }

        public int AS02_FindMaxLessThan(int[] array, int target)
        {
            int currMax = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < target && array[i] > currMax)
                {
                    currMax = array[i];
                }
            }

            return currMax == int.MinValue ? -1 : currMax;
        }

        public int[] AS03_FindRange(int[] array, int min, int max)
        {
            var result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= min && array[i] <= max)
                {
                    result.Add(array[i]);
                }
            }

            return result.ToArray();
        }

        #endregion

        #region Extra

        public int[] EX01_FindTargetEnemies(int[] enemyHPs, int mana)
        {
            var sorted = enemyHPs.OrderBy(hp => hp).ToArray();
            var result = new List<int>();

            for (int i = 0; i < sorted.Length; i++)
            {
                int num = sorted[i];
                if (num <= mana)
                {
                    result.Add(num);
                    mana -= num;
                }

                if (mana <= 0)
                {
                    break;
                }
            }

            return result.ToArray();
        }

        #endregion
    }
}
