// INSERTION SORT

public class InsertionSortSolution
{
    public static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            //i = 1, 2
            var curr = array[i]; //4, 2
            var j = i - 1; //0, 1

            while (j >= 0 && array[j] > curr)
            {
                array[j + 1] = array[j];
                j--;
            }

            //remains same if array[j] < curr
            array[j + 1] = curr;
        }
    }
}