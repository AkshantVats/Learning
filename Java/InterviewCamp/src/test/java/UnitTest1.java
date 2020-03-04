////Given an array of numbers, replace each even number with two of the same number. e.g, [1,2,5,6,8, , , ,] -> [1,2,2,5,6,6,8,8].Assume that the array has the exact amount of space to accommodate the result.

import org.junit.Test;
import static org.junit.Assert.*;

public class UnitTest1 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int []{1,2,5,6,8,-1,-1,-1};
        int[] outputarr = new int [] { 1,2,2,5,6,6,8,8};

        //Act
        int[] output = Class1.CloneEvenNumbers(arr);

        //Assert
        assertArrayEquals(outputarr,output);

    }
}