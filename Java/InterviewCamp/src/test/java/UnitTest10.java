//You are given an array of integers and a pivot. Rearrange the array in the following order:[all elements less than pivot, elements equal to pivot, elements greater than pivot]For example,a = [5,2,4,4,6,4,4,3] and pivot = 4 --> result = [3,2,4,4,4,4,6,5].
import org.junit.Assert;
import org.junit.Test;

public class UnitTest10 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {5,2,4,4,6,4,4,3};
        int[] outputArr = new int[] {3,2,4,4,4,4,6,5};
        int pivot = 4;
        //Act
        int[] output = Class10.PivotArray(arr,pivot);

        //Assert
        Assert.assertArrayEquals(output,outputArr);

    }
}