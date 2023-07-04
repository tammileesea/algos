// TWO SUM II

public class TwoSumTwoSolution {
    // ---------- MY SOLUTION ----------
    // Runtime: 472ms
    // Memory: 46.5MB
    public int[] TwoSum(int[] numbers, int target) {
        int[] result = new int[2];

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    result[0] = i + 1;
                    result[1] = j + 1;
                    return result;
                }
                
                continue;
            }
        }

        return result;
    }

    // ---------- OTHER SOLUTION ----------
    // Runtime: 146ms
    // Memory: 46.1MB

    public int[] TwoSum_2(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;

        while(left < right){
            int sum = numbers[left] + numbers[right];

            if(sum == target) break;
            if(sum < target) left++;
            if(sum > target) right--;
        }

        return new int[] { left + 1, right + 1 };
    }
}

// ---------- NOTES/THOUGHTS -----------
// My solution is brute force- not sophisticated in anyway, just very straightforward 
// I'm trying to learn to be more sophisticated!
// I need to think about approaching algos from different angles now- pointers, direction, etc