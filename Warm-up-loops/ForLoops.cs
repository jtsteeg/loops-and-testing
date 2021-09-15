using System;
using System.Collections.Generic;
using System.Text;

namespace Warm_up_loops
{
    public class ForLoop
    {
        /// <summary>
        /// Return lowest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns lowest number in array.  If array is empty, returns null</returns>
        public int? GetLowest(int[] arr)
        {
            if (arr.Length == 0) return null;
            int lowest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < lowest) lowest = arr[i];
            }
            return lowest;
        }

        /// <summary>
        /// Return highest number in array
        /// </summary>
        /// <param name="arr">System.Int32[]</param>
        /// <returns>Returns highest number in array.  If array is empty, returns null</returns>
        public int? GetHighest(int[] arr)
        {
            if (arr.Length == 0) return null;
            int highest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > highest) highest = arr[i];
            }
            return highest;

        }

        /// <summary>
        /// Return highest number in jagged array
        /// </summary>
        /// <param name="arr">System.Int32[][]</param>
        /// <returns>Returns highest number in array.  If there are no numbers provided, returns null</returns>
        public int? GetHighest(int[][] arr)
        {
            
            int? highest = null;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i].Length > 0)
                    {
                        if (highest == null) highest = arr[i][j];
                        if (arr[i][j] > highest) highest = arr[i][j];
                    }
                }
            }
            return highest;
        }
    }
}
