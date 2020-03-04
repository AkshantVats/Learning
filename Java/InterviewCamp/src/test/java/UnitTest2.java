//Given an array of numbers, move each zero number at the end of the array. e.g, [1,0,5,0,8] -> [1,5,8,0,0].

import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;

public class UnitTest2 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int [] {1, 2, 0, 4, 0, 5, 3, 8};
        int[] outputarr = new int [] {1, 2, 4, 5, 3, 8, 0, 0};

        //Act
        int[] output = Class2.MoveZerosToEnd(arr);

        //Assert
        assertArrayEquals(outputarr,output);

    }
}