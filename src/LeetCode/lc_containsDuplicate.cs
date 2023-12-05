public class ContainsDuplicate {

    //O(n) runtime since worst case scenario is that we go thru the entire array once
    public bool ContainsDuplicateSolution(int[] nums) {
        //fast exit
        if (nums.Length == 1)
        {
            return false;
        }

        List<int> existingVals = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            //if we've not yet added this number to the list yet and we're not at the end of the array, lets add it
            if (!existingVals.Contains(nums[i]))
            {
                Console.WriteLine("value: {0}", nums[i]);
                existingVals.Add(nums[i]);
            }
            //if the list already has this val, then we have a dupe and we can just return true 
            else if (existingVals.Contains(nums[i]))
            {
                return true;
            }
        }

        //if we reach the end of the array and each element has been added to the exiting vals list, then we can simply return false
        return false;
    }

    //hashsets provide high-performance set operations
    //a collection that contains no duplicate elements, in no particular order
    //so obviously, if we put the array into a hashset and the number of elements is different when compared to the input array, 
    //we can determine from that whether or not there are dupes
    public bool ContainsDuplicateSolution_Two(int[] nums) 
    {
        HashSet<int> set = new HashSet<int>(nums);
        
        return nums.Length != set.Count;
    }
}