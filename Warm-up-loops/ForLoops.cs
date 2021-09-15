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
            // throw new NotImplementedException();

            if (arr.Length == 0) return null;

            int lowest = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (lowest > arr[i]) lowest = arr[i];
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
            // throw new NotImplementedException();

            if (arr.Length == 0) return null;

            int highest = arr[0];

            for (var i = 1; i < arr.Length; i++)
            {
                if (highest < arr[i]) highest = arr[i];
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
            // throw new NotImplementedException();

            if (arr.Length == 0) return null;

            int? highest = null;

            for (var i = 0; i < arr.Length; i++)
            {
                for(var k = 0; k < arr[i].Length; k++)
                {
                    if (highest == null) highest = Int32.MinValue;
                    if (highest < arr[i][k]) highest = arr[i][k];
                }
            }

            return highest;
        }

        public int GetHeights
    }
}
