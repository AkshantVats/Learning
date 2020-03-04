//Given a sorted array in non-decreasing order, return an array of squares of each number, also in non-decreasing order. For example:[-4,-2,-1,0,3,5] -> [0,1,4,9,16,25]

import org.junit.Assert;
import org.junit.Test;

public class UnitTest6 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {-4,-2,-1,0,3,5};
        int[] outputArr = new int[] {0,1,4,9,16,25};

        //Act
        int[] output = Class6.squareArrayElement(arr);

        //Assert
        Assert.assertArrayEquals(output,outputArr);

    }
}