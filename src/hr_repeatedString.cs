// REPEATED STRING
// There is a string, , of lowercase English letters that is repeated infinitely many times. Given an integer, , find and print the number of letter a's in the first  letters of the infinite string.

// The substring we consider is , the first  characters of the infinite string. There are  occurrences of a in the substring.

// Function Description

// Complete the repeatedString function in the editor below.

// repeatedString has the following parameter(s):

// s: a string to repeat
// n: the number of characters to consider
// Returns

// int: the frequency of a in the substring

// Input Format:
// The first line contains a single string, s.
// The second line contains an integer, n.

// Constraints:
// For 25% of the test cases, n <= 10^6.

public class RepeatedStringSolution
{
    // ---------- MY SOLUTION ----------
    public static long repeatedString(string s, long n)
        {
            long numberOfA = 0;
            var stringLength = s.Length;
            long result = 0;
            var numberOfStringRepeats = Convert.ToInt64(n/s.Length);
            
            if (n < s.Length)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (s[i].ToString() == "a")
                    {
                        numberOfA++;
                    }
                }
                
                return numberOfA;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].ToString() == "a")
                    {
                        numberOfA++;
                    }
                }
                
                //if the string is repeated without a final partial repeat, just find the number of times A             
                //is repeated in the input string and multiply by how many times the string is repeated
                if (n % s.Length == 0)
                {
                    result = numberOfStringRepeats * numberOfA;
                    return result;
                }
                
                //if there is a partial repetition of the string at the end
                //find how many times the input string is repeated
                //the number of times A appears in the string multiplied by the how many times the string                  
                //is repeated, just need to find the remainder if the string is partially repeated
                var countExceptPartialRep = numberOfStringRepeats * numberOfA;
                var partialRepLength = n - (s.Length * numberOfStringRepeats);
                //how many A's are in the partial repetition ending
                var remainingA = 0;
                for (int i = 0; i < partialRepLength; i++)
                {
                    if (s[i].ToString() == "a")
                    {
                        remainingA++;
                    }
                }
                
                result = countExceptPartialRep + remainingA;
            }

            return result;
        }

    // ---------- OTHER SOLUTION ----------
}

// ---------- NOTES/THOUGHTS -----------