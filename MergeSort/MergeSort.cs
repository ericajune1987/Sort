namespace MergeSort
{
    public class MergeSort
    {
        public static int[] Sort(int[] nums)
        {
            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            } else if (nums.Length == 1)
            {
                return new int[] { nums[0] };
            } else
            {
                int mid = nums.Length / 2;

                int leftLength = mid;
                int rightLength = nums.Length - leftLength;

                int[] left = new int[leftLength];
                int[] right = new int[rightLength];

                for(int x = 0; x < leftLength; x++)
                {
                    left[x] = nums[x];
                }

                for (int x = 0; x < rightLength; x++)
                {
                    right[x] = nums[mid + x];
                }

                int[] leftSorted = Sort(left);
                int[] rightSorted = Sort(right);

                int il = 0;
                int ir = 0;

                int[] sorted = new int[nums.Length];

                for (int x = 0; x < sorted.Length; x++)
                {
                    if ((il < leftSorted.Length) && (ir < rightSorted.Length))
                    {
                        if (leftSorted[il] <= rightSorted[ir])
                        {
                            sorted[x] = leftSorted[il];
                            il++;
                        }
                        else
                        {
                            sorted[x] = rightSorted[ir];
                            ir++;
                        }
                    }
                    else if (il >= leftSorted.Length)
                    {
                        sorted[x] = rightSorted[ir];
                        ir++;
                    }
                    else if (ir >= rightSorted.Length)
                    {
                        sorted[x] = leftSorted[il];
                        il++;
                    }
                }

                return sorted;
            }
        }
    }
}