//Given an array of integers, rearrange the elements such that all zeros are moved to the end of the array.
import org.junit.Assert;
import org.junit.Test;

public class UnitTest9 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {4,2,0,1,0,3,0};
        int[] outputArr = new int[] {4,2,3,1,0,0,0};

        //Act
        int[] output = Class9.RearrangeArray(arr);

        //Assert
        Assert.assertArrayEquals(output,outputArr);

    }
}