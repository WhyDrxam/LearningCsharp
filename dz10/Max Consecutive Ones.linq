<Query Kind="Statements" />

public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {   
var max = 0;
var min = 0;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] == 1)
    {
        min++;
        max = Math.Max(max, min);
    }
    else
    {
        min = 0;
    }
}

        return max;
        
    }
}