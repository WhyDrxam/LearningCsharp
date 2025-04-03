<Query Kind="Statements" />

public class Solution {
    public int[] SortArrayByParity(int[] nums) {
        List<int> even = new();
List<int> odd = new();
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] % 2 != 0)
    {
        odd.Add(nums[i]);
    }
    else if (nums[i] % 2 == 0)
    {
        even.Add(nums[i]);
    }
}

for (int i = 0; i < even.Count; i++)
{
    nums[i] = even[i];
}

int oddPos = 0;
for (int i = even.Count; i < nums.Length; i++)
{
    nums[i] = odd[oddPos];
    oddPos++;
}

return nums;
        
    }
}