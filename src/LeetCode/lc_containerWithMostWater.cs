public class ContainerWithMostWater {
    //memory: O(1) since we're just storing some constants
    //runtime: O(n)
    public int ContainerWithMostWaterSolution(int[] height) {
        //start at the beginning of the height array
        //2 pointers to represent a window, but in this case, it would basically be the width of the container

        if (height.Length == 2)
        {
            return GetArea(0, 1, height[0], height[1]);
        }

        var left = 0;
        var right = 1;
        var area = GetArea(left, right, height[left], height[right]);

        while (right > left && right < height.Length && left < height.Length - 1)
        {
            if (right == height.Length - 1)
            {
                if (left == height.Length - 2)
                {
                    break;
                }
                else
                {
                    left++;
                    right = left + 1;
                }
            }
            else
            {
                right++;
            }

            var newArea = GetArea(left, right, height[left], height[right]);

            if (area < newArea)
            {
                area = newArea;
            }
        }

        return area;
    }

    public int GetArea(int left, int right, int leftHeight, int rightHeight)
    {
        var area = (right - left) * rightHeight;

        if (leftHeight < rightHeight)
        {
             area = (right - left) * leftHeight;
        }
        
        return area;
    }

    //NOTES
    //so my solution is really no different from a nested for loop, 
    //but it just didn't occur to me to have the pointers at opposite ends of the input array
    //so my logic works but takes WAY too much time
    //I'm pretty sure that this is O(n) bc we actually don't ever go thru the entire array more than once 
    //but it certainly makes sense to have each pointer at opposite ends now, which is definitely O(n) runtime

    public int ContainerWithMostWaterSolution_Two(int[] height) 
    {
        int l = 0,
            r = height.Length - 1,
            current_max = 0,
            max = 0;

        while (l < r)
        {
            current_max = (r - l) * Math.Min(height[l], height[r]); //math.min function good
            if (current_max > max) 
                max = current_max;
				
            if (height[l] <= height[r])
                l++;
            else
                r--;
        }
        
        return max;
    }
}