<Query Kind="Statements" />

public class Solution {
    public bool CheckIfExist(int[] arr) {
        bool flag = false;
for (int i = 0; i < arr.Length; i++)
{
    for (int j = 0; j < arr.Length; j++)
    {
        if (i != j && arr[i] == arr[j] * 2)
        {
            flag = true;
        }
        
    }
}
return flag;
        
    }
}