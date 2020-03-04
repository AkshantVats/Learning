//Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i"

import org.junit.Assert;
import org.junit.Test;

import static org.junit.Assert.assertArrayEquals;
import static org.junit.Assert.assertSame;

public class UnitTest3 {

    @Test
    public void When_Input_Correct() {

        //Arrange
        String str = "i live in a house";
        String outputstr = "house a in live i";
        //Act
        String output = Class3.ReverseWordsOfStrings(str);

        //Assert
        Assert.assertEquals(output,outputstr);

    }
}