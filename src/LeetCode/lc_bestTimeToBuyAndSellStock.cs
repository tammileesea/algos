// BEST TIME TO BUY AND SELL STOCK


public class SellStockSolution {
    // ---------- MY SOLUTION ----------
    // Runtime: Time exceeded
    // Memory: ???
    public int MaxProfit(int[] prices) {
        int greatestDiff = 0;

        //basically find the largest difference where the smaller number comes earlier in the array than the larger number
        //[7, 3, 4, 6, 2, 5, 1] ==> 4
        //[7,1,5,3,6,4] ==> 5
        //[7,6,4,3,1] ==> 0

        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if ((j < prices.Length - 1) && prices[j] < prices[j + 1])
                {
                    continue;
                }
                else if (prices[i] < prices[j] && ((prices[j] - prices[i]) > greatestDiff))
                {
                    greatestDiff = prices[j] - prices[i];
                }
                else
                {
                    continue;
                }
            }
        }

        return greatestDiff;
    }

    // ---------- OTHER SOLUTION ----------
    public int MaxProfit_2(int[] prices) {
        int low = prices[0];
        int trade = 0;

        foreach (int x in prices)
        {
            if (x - low > trade)
            {
                trade = x - low;
            }

            if (x < low)
            {
                low = x;
            }
        }

        return trade;
    }

    // [7, 1, 5, 3, 6, 4]
    // low = 7, 7, 1, 1, 1, 1
    // x = 7, 1, 5, 3, 6, 4
    // trade = 0, 0, 4, 4, 5, 5


    public int MaxProfit_3(int[] prices) {
        int windowStart = 0;
        int maxProfit = 0;

        for (int i = 0; i < prices.Count(); i++) {

            var l = prices[windowStart];
            var r = prices[i];

            if (l < r)
            {
                maxProfit = Math.Max(r - l, maxProfit);
            }
            else
            {
                windowStart = i;
            }
        }

        return maxProfit;
    }
}

// ---------- NOTES/THOUGHTS -----------
// Again, I was brute-forcing, but I was thinking of using a pointer, I just didn't really go about it well.
// Because the pointer essentially removes the need for a nested/additional forloop