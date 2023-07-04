// BUBBLE SORT

public class BubbleSort
{
    public static void countSwaps(List<int> a)
    {
        var swapCount = 0;
        
        for (int i = 0; i < a.Count(); i++)
        {
            //subtract i so that you iterate one time less each time you sort
            for (int j = 0; j < a.Count() - i - 1; j++)
            {
                if (a[j] > a[j + 1])
                {
                    var temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapCount++;
                }
            }
            
            //if there were no swaps, that means the array is sorted so break
            if (swapCount == 0)
            {
                break;
            }
        }
    }
}