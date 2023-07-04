// VALID ANAGRAM 

// Given two strings s and t, return true if t is an anagram of s, and false otherwise.
// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

// ---------- MY SOLUTION ----------
// Runtime: 932ms
// Memory: 60.5MB

public class AnagramSolution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        //turn 2nd word into array
        //remove elements that exist in first word
        //by end of for loop, if 2nd word array is empty, then its an anagram, return true

        var secondWordArr = t.ToCharArray();
        var secondWord = t;

        for (int i = 0; i < s.Length; i++)
        {
            if (secondWord.IndexOf(s[i].ToString()) >= 0)
            {
                var index = secondWord.IndexOf(s[i].ToString());
                secondWord = secondWord.Remove(index, 1);
            }
        }

        if (secondWord.Length == 0)
        {
            return true;
        }

        return false;
    }


    // Runtime: 101ms
    // Memory: 49MB

    public bool IsAnagram_2(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<string, int> existingLetters = new Dictionary<string, int>();
        Dictionary<string, int> secondWord = new Dictionary<string, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (existingLetters.ContainsKey(s[i].ToString()))
            {
                existingLetters[s[i].ToString()]++;
            }
            else
            {
                existingLetters.Add(s[i].ToString(), 1);
            }

            if (secondWord.ContainsKey(t[i].ToString()))
            {
                secondWord[t[i].ToString()]++;
            }
            else
            {
                secondWord.Add(t[i].ToString(), 1);
            }
        }

        if (existingLetters.Count == secondWord.Count)
        {
            foreach (var pair in existingLetters.ToList())
            {
                if (!secondWord.ContainsKey(pair.Key))
                {
                    return false; 
                }
                else if (secondWord.ContainsKey(pair.Key) && pair.Value != secondWord[pair.Key])
                {
                    return false;
                }

                continue;
            }

            return true;
        }
        else
        {
            return false;
        }

        return false;
    }
}