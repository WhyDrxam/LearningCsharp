<Query Kind="Statements" />

public class Solution {
    public bool ValidMountainArray(int[] arr) {
        int dude = 0;

while (dude + 1 < arr.Length && arr[dude] < arr[dude +1])
{
    dude++;
}

if (dude == 0 || dude == arr.Length - 1)
{
    return false;
}

while (dude + 1 < arr.Length && arr[dude] > arr[dude + 1])
{
    dude++;
}

return dude == arr.Length - 1;
        
    }
}