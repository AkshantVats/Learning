//You're given a list of Marbles. Each marble can have one of 3 colors (Red, White or Blue).Arrange the marbles in order of the colors (Red -> White -> Blue).Colors are represented as follows:0 - Red 1 - White 2 - Blue
import org.junit.Assert;
import org.junit.Test;

public class UnitTest11 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        int[] arr = new int[] {2,1,0,2,2,0,1};
        int[] outputArr = new int[] {0,0,1,1,2,2,2};
        //Act
        int[] output = Class11.marblesArray(arr);
        //Assert
        Assert.assertArrayEquals(output,outputArr);
    }
}