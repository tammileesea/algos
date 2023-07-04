// Each time Sunny and Johnny take a trip to the Ice Cream Parlor, they pool their money to buy ice cream. 
//On any given day, the parlor offers a line of flavors. Each flavor has a cost associated with it.

// Given the value of  and the  of each flavor for  trips to the Ice Cream Parlor, 
//help Sunny and Johnny choose two distinct flavors such that they 
//spend their entire pool of money during each visit. 
//ID numbers are the 1- based index number associated with a . 
//For each trip to the parlor, print the ID numbers for the two types of ice cream that 
//Sunny and Johnny purchase as two space-separated integers on a new line. 
//You must print the smaller ID first and the larger ID second.

// Example
// cost = [2, 1, 3, 5, 6]
// money = 5

// They would purchase flavor ID's  and  for a cost of . Use  based indexing for your response.

// Note:
// Two ice creams having unique IDs  and  may have the same cost (i.e., ).
// There will always be a unique solution.

public class IceCreamParlorSolution
{
    public static void whatFlavors(List<int> cost, int money)
    {
        var map = new Dictionary<int, List<int>>();
        for(int i = 0; i < cost.Count; i++)
        {
            if (map.ContainsKey(cost[i]))
            {
                map[cost[i]].Add(i + 1);
            }
            else
            {
                map[cost[i]] = new List<int> { i + 1 };
            }
        }
        
        for (int i = 0; i < cost.Count; i++)
        {
            var target = money - cost[i];
            if (map.ContainsKey(target)) 
            {
                if (map[target][0] != (i + 1))
                {
                    Console.WriteLine((i + 1).ToString() + " " + map[target][0]);
                    return;
                }
                else if (map[target].Count > 1)
                {
                    Console.WriteLine((i + 1).ToString() + " " + map[target][1]);
                    return;                                       
                }
            }
        }
    }
}

// 4
// 1 4 5 3 2

// 4
// 2 2 4 3

// i: 0
// remainder: 3
// first: 0
// second: 3
// 1 4
// i: 0
// remainder: 2