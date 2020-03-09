//Given an array of integers, both -ve and +ve, find a contiguous subarray that sums to 0.For example: [2,4,-2,1,-3,5,-3] --> [4,-2,1,-3]

import java.util.HashMap;

public class Class15 {

    public static int[] contiguousArray(int[] arr)
    {
        if(arr == null || arr.length == 0) {
            return null;
        }

        int sum = 0;
        HashMap<Integer, Integer> map = new HashMap<>();

        for (int i = 0; i < arr.length ; i++) {

            sum += arr[i];

            if(sum == 0) {
                return new int[]{0, i};
            }

            if(map.containsKey(sum))
            {
                return new int[] { map.get(sum)+1 , i};
            }

            map.put(sum ,i );

        }

        return null;
    }
}
