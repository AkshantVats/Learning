//Given a String, find the longest substring with unique characters.For example: "whatwhywhere" --> "atwhy"

import com.sun.tools.javac.util.Pair;

import java.util.HashMap;

public class Class14 {

    public static int[] uniqueChars(String input)
    {
        if(input == null || input.length() == 0) {
            return null;
        }

        int first = 0, second = 0;
        int start = 0, end = 0, longest = 0;
        HashMap<Character,Integer> map = new HashMap<>();
        map.put(input.charAt(0),0);

        while (end < input.length()-1)
        {
            end++;
            char toAdd = input.charAt(end);
            if( map.containsKey(toAdd) && map.get(toAdd) >= start)
            {
                start = map.get(toAdd) + 1;
            }

            map.put(toAdd,end);

            if(end - start + 1 > longest)
            {
                longest = end - start + 1;
                first = start;
                second = end;
            }
        }

        return new int[] {first, second};

    }
}
