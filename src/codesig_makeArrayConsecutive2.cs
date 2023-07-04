// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, 
// each statue having an non-negative integer size. 
// Since he likes to make things perfect, 
// he wants to arrange them from smallest to largest so that each statue will be bigger than the previous one exactly by 1. 
// He may need some additional statues to be able to accomplish that. 
// Help him figure out the minimum number of additional statues needed.

// Example

// For statues = [6, 2, 3, 8], the output should be
// solution(statues) = 3.

// Ratiorg needs statues of sizes 4, 5 and 7.

public class StatueSolution
{
    // ---------- MY SOLUTION ----------
    int solution(int[] statues) {
        //find min
        //find max
        //which numbers are missing in between- DONT ACTUALLY NEED
        //if so, how many are missing
        
        int min = statues[0];
        int max = statues[0];
        int numberOfStatuesNeeded = 0;
        
        for (int i = 1; i < statues.Length; i++)
        {        
            if (statues[i] < min)
            {
                min = statues[i];
            }
            else if (statues[i] > max)
            {
                max = statues[i];
            }
        }
        
        int x = max - min + 1;
        
        numberOfStatuesNeeded = x - statues.Length;

        return numberOfStatuesNeeded;
    }

    // ---------- OTHER SOLUTION ----------
    int solution_2(int[] sequence) {
        return sequence.Max() - sequence.Min() - sequence.Length + 1;
    }
}

// ---------- NOTES/THOUGHTS -----------
// Remember what data or values are necessary to know and keep track of!
// The solution here didn't require which values were needed to fully sort the int array,
// it only required HOW MANY values were missing.
// So I spent my time trying to figure out how to keep track of basically each value in the array,
// as well as the missing values,
// but all I needed to do was a simple calculation after finding the min and max values.