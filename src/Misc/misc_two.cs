public class MiscTwo
{
    // Create a function that, given an array of non-negative integers and an integer n, find the longest contiguous subarray that sums to exactly n. Give me the length of longest subarray as return value.

    // n = 8
    // [1, 3, 5, 8]
    // [3, 5] length = 2

    // n = 5
    // [1, 4, 3, 0, 2, 2, 3, 1, 6, 9]
    // [1, 4, 0, 0, 2, 2, 3, 1, 6, 9]
    // [1, 4, 1, 0]
    // [1, 4, 2, 0]

    // sum <= n
    // [3, 1, {2, 0, 1}, 6, 3, 2, 0]
    // [3, 1, {2, 0, 1, 6}, 3, 2, 0]

    // sum > n
    // [3, 1, {2, 0, 4}, 6, 3, 2, 0]
    // [3, 1, 2, {0, 4}, 6, 3, 2, 0]
    // 3
    // Pointer at [2], [4], sum (for convenience)

    // [3, 1, 2, 0, 1, 6, 3, 2, 0]
    // [{8} 5]
    // [8{} 5]
    // [8{ 5}]

    // Sum = 0
    // Left = 1
    // Right = 1
    // [8 5]

    public static int LongestSubarray(int[] arr, int n)
    {
        int lengthOfSubarray = 0;
        int left = 0; // inclusive
        int right = 0; // inclusive
        int sum = arr[0];

        while (right < arr.Length - 1)
        {
            if (sum == n && lengthOfSubarray < (right - left + 1))
            {
                lengthOfSubarray = right - left + 1;
            }

            // State is consistent
            if (sum <= n && right < arr.Length - 1)
            {
                right++;
                sum += arr[right];
            }
            else if (sum > n)
            {
                // Normal case
                sum -= arr[left];
                left++;

                // Special case
                if (sum == 0 && right < left)
                {
                    sum = arr[left];
                    right++;
                }

            }
            // State should be consistent
        }

        if (sum == n && lengthOfSubarray < (right - left + 1))
        {
            lengthOfSubarray = right - left + 1;
        }

        return lengthOfSubarray;
    }
}