// VALID PALINDROME

// A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and 
// removing all non-alphanumeric characters, it reads the same forward and backward. 
// Alphanumeric characters include letters and numbers.
// Given a string s, return true if it is a palindrome, or false otherwise.

// ---------- MY SOLUTION ----------
// Runtime: 74ms
// Memory: 41.3MB

public class ValidPalindromeSolution {
    public bool IsPalindrome(string s) {
        s = s.ToLower();
        s = new string(s.Where(q => char.IsLetterOrDigit(q)).ToArray());

        decimal halfway = s.Length/2;
        int final = s.Length - 1;

        for (int i = 0; i < halfway; i++)
        {
            if (s[i] != s[final] && final >= halfway)
            {
                return false;
            }
            else if (s[i] == s[final] && final >= halfway )
            {
                final--;
                continue;
            }
        }

        return true;
    }
}

// ---------- OTHER SOLUTION ----------


// ---------- NOTES/THOUGHTS -----------
