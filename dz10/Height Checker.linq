<Query Kind="Statements" />

public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = new int[heights.Length];
for (int i = 0; i < expected.Length; i++)
{
    expected[i] = heights[i];
}
Array.Sort(expected);
int k = 0;
for (int i = 0; i < heights.Length; i++)
{
    if (heights[i] != expected[i])
    {
        k++;
    }
}

return k;
        
    }
}