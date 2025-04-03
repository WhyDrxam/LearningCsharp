<Query Kind="Statements" />

public class Solution {
    public int ThirdMax(int[] nums) {
        HashSet<int> uniqueNumbers = new HashSet<int>(nums);

        int[] sortedNumbers = uniqueNumbers.OrderByDescending(x => x).ToArray();

        if (sortedNumbers.Length < 3)
        {
            return sortedNumbers[0];
        }
        else
        {
            return sortedNumbers[2];
        }
    }
    }
