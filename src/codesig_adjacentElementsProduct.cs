// Given an array of integers, 
// find the pair of adjacent elements that has the largest product and return that product.

// Example
// For inputArray = [3, 6, -2, -5, 7, 3], the output should be
// solution(inputArray) = 21.

// 7 and 3 produce the largest product.

public class AdjacentProductSolution
{
    // ---------- MY SOLUTION ----------
    int solution(int[] inputArray) {
        if (inputArray.Length < 3) //fast exit
        {
            return inputArray[0]*inputArray[1];
        }
        
        //array values can be negative
        //use for loop?
        //repeated values
        //store products in separate array?
        
        int product = inputArray[0] * inputArray[1];
        
        for (int i = 1; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] * inputArray[i + 1] > product)
            {
                product = inputArray[i] * inputArray[i + 1];
            }
        }
        
        return product;
    }

    // ---------- OTHER SOLUTION ----------
    public int AdjacentElementsProduct(int[] inputArray) {
        return inputArray.Select((i, j) => j > 0 ? i * inputArray[j-1] : int.MinValue).Max();
    }

    // ---------- THOUGHTS + NOTES ----------
    // the more succinct solution is more like syntactical sugar- 
    //I think they sliced the array, so they were able to read values more quickly
    // but I generally feel like interviewers want to see how you think, versus what kind of syntax you know?

    // ---------- I MISUNDERSTOOD LOL ----------
    // OK so if this was about finding the two highest values, 
    //regardless of where the values are in the array, i think this likely would've worked???

    int AdjacentElementsProduct_2(int[] inputArray) {
        if (inputArray.Length < 3) //fast exit
        {
            return inputArray[0]*inputArray[1];
        }
        
        //array values can be negative
        //use for loop?
        //repeated values
        //store in separate array?
        
        //if all values are negative
        //[9, 8, 7]
        //[9, 7, 8]
        //[8, 7, 9]
        //[8, 9, 7]
        //[7, 8, 9]
        //[7, 9, 8]
        
        int higherOne = inputArray[0];
        int higherTwo = inputArray[1];
        
        for (int i = 2; i < inputArray.Length - 1; i++)
        {
            if (higherOne < inputArray[i] && higherOne < higherTwo)
            {
                higherOne = inputArray[i];
            }
            else if (higherTwo < inputArray[i] && higherTwo < higherOne)
            {
                higherTwo = inputArray[i];
            }
        }
        
        return higherOne * higherTwo;
    }
}