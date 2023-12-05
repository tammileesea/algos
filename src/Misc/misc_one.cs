//if I remember this correctly, each pair consists of different numbers
//eg [1, 1, 2, 2, 3]
//1 <= fruits[1] <= 10^9
//{1, 1, 2, 3}
//{1, 1, 2, 2, 3}
//{8, 1, 2, 3, 4, 5, 8, 6, 7, 8, 8, 8, 8}

public class MiscOne
{
    public int ArrayPairs(int[] array)
    {
        var remaining = array.Length;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                continue;
            }

            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] == 0)
                {
                    continue;
                }

                if (array[i] != array[j])
                {
                    //this would be considered a pair, so both values will be set to 0 since all vals in array are greater than 1
                    array[i] = 0;
                    array[j] = 0;

                    //since this is a crushable pair, we can remove them from the total count
                    remaining-=2;

                    //break out of nested loop
                    break;
                }
                else
                {
                    continue;
                }
            }
        }

        return remaining;
    }
}