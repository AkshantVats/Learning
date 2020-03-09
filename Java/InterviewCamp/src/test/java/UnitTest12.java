//Given an array of integers that can be both +ve and -ve, find the contiguous subarray with the largest sum.For example: [1,2,-1,2,-3,2,-5] -> first 4 elements have the largest sum. Return (0,3)
import org.junit.Assert;
import org.junit.Test;

public class UnitTest12 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {1,2,-1,2,-3,2,-5};
        int outputArr = 4;
        //Act
        int output = Class12.continuousSubArray(arr);
        //Assert
        Assert.assertEquals(output,outputArr);
    }
}