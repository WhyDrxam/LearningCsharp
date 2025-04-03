<Query Kind="Statements" />

public class Solution {
    public int FindNumbers(int[] nums) {
        var result = 0;
var count = 0;
for (int i = 0; i < nums.Length; i++)
{
    while (nums[i] > 0)
    {
        nums[i] = nums[i] / 10;
        count++;
    }

    if (count % 2 == 0)
    {
        result++;
    }
    count = 0;
}
        return result;
    }
}