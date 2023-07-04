// PALINDROME
// Given the string, check if it is a palindrome.

// For inputString = "aabaa", the output should be
// solution(inputString) = true;
// For inputString = "abac", the output should be
// solution(inputString) = false;
// For inputString = "a", the output should be
// solution(inputString) = true.
// Input/Output

// [execution time limit] 0.5 seconds (cs)

// [input] string inputString

// A non-empty string consisting of lowercase characters.

// Guaranteed constraints:
// 1 ≤ inputString.length ≤ 105.

// [output] boolean

// true if inputString is a palindrome, false otherwise.

// ----------- SOLUTION ----------
public class Solution {
    public bool IsPalindrome(string inputString) {
    var count = inputString.Length;
    var arr = inputString.ToCharArray();
    
    if (count == 1) //fast exit
    {
        return true;
    }
    
    if (count%2 == 1) //accounting for remainder
    {
        var middle = (int)Math.Floor((double)count/2); //accounting for array position
        var left = middle - 1;
        var right = middle + 1;
        
        for (int i = middle; i < count - 1; i++)
        {
            if (arr[left] == arr[right])
            {
                left--;
                right++;
                
                if (left == 0 && right == count - 1)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        
        return false;
    }
    else if (count%2 == 0)
    {
        var left = count/2 - 1; //accounting for array position
        var right = left + 1;
        
        for (int i = left; i < count - 1; i++)
        {
            if (arr[left] == arr[right])
            {
                left--;
                right++;
                
                if (left == 0 && right == count - 1)
                {
                    return true;
                }
            }
            else 
            {
                return false;
            }
        }
        
        return false;
    }
    
        return false;
    }
} 

// --------- BETTER SOLUTION ----------

// bool solution(String inputString) {
//     for(int i = 0; i < inputString.length()/2; i++){
//         if(inputString.charAt(i) != inputString.charAt(inputString.length()-i-1))
//             return false;
//     }
//     return true;
// }

// --------- THOUGHTS + NOTES ----------
// so I clearly did a much more complex approach lol
// I accounted for whether or not the word even has an odd or even number of letters
// I started in the middle of the word, and went to the letter on each side of the middle and moved outward
// the faster approach seems to start at the beginning of the word, 
//for loop ends at the middle, and checks for the character on the opposite end, 
// calculating that position using 'i'