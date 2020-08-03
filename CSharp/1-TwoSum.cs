public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        var mapping = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            mapping[nums[i]] = i;
        }
        
        for (var i = 0; i < nums.Length; i++)
        {
            var targetValue = target - nums[i];
            if (mapping.ContainsKey(targetValue) && i != mapping[targetValue])
            {
                return new int[] {i, mapping[targetValue]};
            }
        }
        
        return new int[0];
    }
}