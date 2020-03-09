//You are given an array of integers. Rearrange the array so that all zeroes are at the beginning of the array.For example,a = [4,2,0,1,0,3,0] -> [0,0,0,1,2,3,4]

import org.junit.Assert;
import org.junit.Test;

public class UnitTest8 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {4,2,0,1,0,3,0};
        int[] outputArr = new int[] {0,0,0,1,2,3,4};

        //Act
        int[] output = Class8.RearrangeArray(arr);

        //Assert
        Assert.assertArrayEquals(output,outputArr);

    }
}