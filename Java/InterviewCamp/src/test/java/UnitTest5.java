//2 Sum Problem: Given a sorted array of integers, find two numbers in the array that sum to a given integer target.For example, if a = [1,2,3,5,6,7] and target = 11, the answer will be 5 and 6.

import org.junit.Assert;
import org.junit.Test;

public class UnitTest5 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {1,2,3,5,6,7};
        int[] outputarr = new int[] {5,6};
        int target = 11;

        //Act
        int[] output = Class5.TwoSumProblem(arr,target);

        //Assert
        Assert.assertArrayEquals(output,outputarr);

    }
}