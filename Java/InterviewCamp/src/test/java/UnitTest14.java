//Given a String, find the longest substring with unique characters.For example: "whatwhywhere" --> "atwhy"
import org.junit.Assert;
import org.junit.Test;

public class UnitTest14 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        String input = "whatwhywhere";
        int[] outputArr = new int[] { 2,6 };

        //Act
        int[] output = Class14.uniqueChars(input);
        //Assert
        Assert.assertArrayEquals(output,outputArr);
    }
}