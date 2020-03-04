//Given a sentence, reverse the words of the sentence.For example,"i live in a house" becomes "house a in live i"

public class Class3 {

    public static String ReverseWordsOfStrings(String str)
    {
        if(str == null || str.isEmpty())
        {
            return  null;
        }

        int i = str.length()-1, end = str.length();
        StringBuilder sb = new StringBuilder();

        while(i >0)
        {
            if(str.charAt(i) == ' ')
            {
                if(sb.length() > 0)
                {
                    sb.append(' ');
                }

                sb.append(str.substring(i+1,end));

                end = i;
            }

            i--;
        }

            if(sb.length() > 0)
            {
                sb.append(' ');
            }

            sb.append(str.substring(i,end));


            return sb.toString();
    }
}
