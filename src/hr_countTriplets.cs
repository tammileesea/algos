// COUNT TRIPLETS

public class CountTripletsSolution
{
    // ---------- MY SOLUTION ----------
        static long countTriplets(List<long> arr, long r) {
            if (arr.Count() < 3)
            {
                return 0;
            }
            
            var triplets = new List<int[]>();
            
            for (int i = 0; i < arr.Count(); i++)
            {
                var second = (long)arr[i] * r;
                var third = (long)second * r;
                if (arr.Contains(second) && arr.Contains(third))
                {
                    // list.FindAll(delegate(string s){return s == "match";});
                    List<long> secondIndices = arr.FindAll(delegate(long l){return l == second;});
                    List<long> thirdIndices = arr.FindAll(delegate(long l){return l == third;});
                    
                    if (secondIndices.Count() > 1)
                    {
                        
                    }
                    
                    var triplet = new int[]{i};
                    
                    if (!triplets.Contains(triplet))
                    {
                        triplets.Add(triplet);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            
            return triplets.Count();
        }

    // ---------- OTHER SOLUTION ----------
    static long countTriplets_2(List<long> arr, long r) 
    {
        long count = 0L;
        Dictionary<double, long> after = new Dictionary<double, long>();
        Dictionary<double, long> before = new Dictionary<double, long>();

        //add all array vals to 2 dics
        foreach(double item in arr)
        {
            //keeping account of how many times each val appears in list
            if(after.ContainsKey(item))
            {
                after[item] += 1;
            }
            else 
            {
                after.Add(item, 1);
            }

            //adding all elements as key where val is 0
            if(!before.ContainsKey(item))
            {
                before.Add(item, 0);
            } 
        }

        //[1, 5, 5, 25, 125]
        //r = 5

        // {
        //     { 1, 1 },
        //     { 5, 2 },
        //     { 25, 1 },
        //     { 125, 1 }
        // }

        // {
        //     { 1, 1 },
        //     { 5, 2 },
        //     { 25, 1 },
        //     { 125, 1 }
        // }

        foreach(double item in arr)
        {
            after[item] -= 1; //middle: 1, 5, 5, 25
            var af = item * r; //upper: 5, 25, 25, 125
            var bf = item / r; //lower: 1/5, 1, 1, 5

            if (after.ContainsKey(af) && before.ContainsKey(bf))
            {
                count += (after[af] * before[bf]);
                //count = count + (after[af] * before[bf])
                //round 1:: 0
                //round 2:: 0 + (1 * 1) = 1 (5)
                //round 3:: 1 + (1 * 1) = 2 (5)
                //round 4:: 2 + (1 * 2) = 4 (25)
                //round 5:: 4 + 0
            }

            before[item] += 1;    
        }

        return count;
    }
}

// ---------- NOTES/THOUGHTS -----------
// first for loop adds all values to 2 diff dictionaries- one where each array element is counted and 
// another where each element's value is later altered, starting at 0

// the second for loop then does all the calculating
// each element in the input array is set at the middle value of the triplet
// find the upper and lower values
// if the upper exists in the first dictionary and the lower exists in the second dictionary
// then calculate the count ==> count = count + (after[af] * before[bf]) (I dont get this?????)
// values in the first dictionary aren't altered during the second for loop, only the second dictionary

// second dictionary ultimately ends up the same at the first after the second loop finishes