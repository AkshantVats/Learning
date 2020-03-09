//Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]
import org.junit.Assert;
import org.junit.Test;

public class UnitTest15 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] inputArr = new int[] {2,4,-2,1,-3,5,-3};
        int[] outputArr = new int[] { 1,4 };

        //Act
        int[] output = Class15.contiguousArray(inputArr);
        //Assert
        Assert.assertArrayEquals(output,outputArr);
    }
}