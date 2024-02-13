using System;

namespace MyMath{

    public class Operations{

        /// <summary>
        /// Finds the maximum integer in a list.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>The maximum integer in the list, or 0 if the list is empty.</returns>
        public static int Max(List<int> nums)
        {
            int listLength = nums.Count;
            if (listLength == 0)
            {
                return 0;
            }
            else
            {
                if (nums != null)
                {
                    int MaxSoFar = nums[0];
                    for (int i = 1; i < listLength; i++)
                    {
                        if (nums[i] > MaxSoFar)
                        {
                            MaxSoFar = nums[i];
                        }
                    }

                    return MaxSoFar;
                }
            }

            return 0;
        }
    }
}