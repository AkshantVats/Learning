//Given an array, reverse the order of its elements.For example, [3,5,2,5,2,3,9] → [9,3,2,5,2,5,3]

import org.junit.Assert;
import org.junit.Test;

public class UnitTest4 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {1,2,3,4,5};
        int[] outputarr = new int[] {5,4,3,2,1};
        //Act
        int[] output = Class4.ReverseArray(arr);

        //Assert
        Assert.assertArrayEquals(output,outputarr);

    }
}