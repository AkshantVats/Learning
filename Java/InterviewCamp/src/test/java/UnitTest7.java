//Given an array of integers, find the shortest sub array, that if sorted, results in the entire array being sorted.For example:[1,2,4,5,3,5,6,7] --> [4,5,3] - If you sort from indices 2 to 4, the entire array is sorted.[1,3,5,2,6,4,7,8,9] --> [3,5,2,6,4] - If you sort from indices 1 to 5, the entire array is sorted.

import org.junit.Assert;
import org.junit.Test;

public class UnitTest7 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {1,3,5,2,6,4,7,8,9};
        int[] outputArr = new int[] {1,5};

        //Act
        int[] output = Class7.shortestSubArray(arr);

        //Assert
        Assert.assertArrayEquals(output,outputArr);

    }
}