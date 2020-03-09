//Given an array of positive integers, find a subarray that sums to a given number X.For e.g, input = [1,2,3,5,2] and X=8, Result = [3,5] (indexes 2,3)
import org.junit.Assert;
import org.junit.Test;

public class UnitTest13 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {1,2,3,5,2};
        int target = 8;
        int[] outputArr = new int[] {3,5};
        //Act
        int[] output = Class13.continuousSubArray(arr,target);
        //Assert
        Assert.assertArrayEquals(output,outputArr);
    }
}