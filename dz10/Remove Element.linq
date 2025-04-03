<Query Kind="Statements" />

public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0; 

        for (int readIndex = 0; readIndex < nums.Length; readIndex++) {
            if (nums[readIndex] != val) {
                nums[k] = nums[readIndex]; 
                k++; 
            }
        }

        return k;
        
    }
}