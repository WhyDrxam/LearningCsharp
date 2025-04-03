<Query Kind="Statements" />

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p = 0;
for (int i = m; i < m +n; i++)
{
    nums1[i] = nums2[p++];
}
Array.Sort(nums1);
        
    }
}