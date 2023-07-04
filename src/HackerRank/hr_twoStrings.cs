// TWO STRINGS

// Given two strings, determine if they share a common substring. 
// A substring may be as small as one character.

// Example
// s1 = "and"
// s2 = "art"
// These share the common substring 'a'.

// s1 = "be"
// s2 = "cat"
// These do not share a substring.

// twoStrings has the following parameter(s):
// string s1: a string
// string s2: another string

// Returns
// string: either YES or NO

public class TwoStringsSolution
{
    // ---------- MY SOLUTION ----------
    public static string twoStrings(string s1, string s2)
    {
        string shorter = s1;
        string longer = s2;
        
        if (s2.Length < s2.Length)
        {
            shorter = s2;
            longer = s1;
        }
        
        for (int i = 0; i < shorter.Length; i++)
        {
            if (longer.Contains(shorter[i].ToString()))
            {
                // var comparisonStart = longer.IndexOf(shorter[i].ToString());
                return "YES";
            }
        }
        
        return "NO";
    }

    // ---------- OTHER SOLUTION ----------
    // (1) USING INTERSECT
    public static string twoStrings_2(string s1, string s2) 
    { 
        return s1.Intersect(s2).Count() > 0 ? "YES" : "NO"; 
    }

    // (2)
    public static String twoStrings_3(String s1, String s2) 
    {
        // Map<Character, Integer> m = new HashMap<>();
        
        // for(Character c: s1.toCharArray()) {
        //     m.put(c, 1);s
        // }
        
        // for(Character c: s2.toCharArray()) {
        //     if(m.containsKey(c)) {
        //         return "YES";
        //     }
        // }
        
        return "NO";
    }
}

// ---------- NOTES/THOUGHTS -----------