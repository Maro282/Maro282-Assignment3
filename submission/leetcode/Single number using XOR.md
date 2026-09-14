
profile link => https://leetcode.com/u/marawanelsawy00/

problem solution link (two sum) => https://leetcode.com/problems/single-number/solutions/8519888/single-number-by-using-xor-by-marawanels-eqjm/

# Intuition

Every number appears twice except one. Since XOR has the property that x ^ x = 0 and x ^ 0 = x, the duplicate numbers cancel each other out, leaving only the number that appears once.

# Approach

Initialize result to 0 and iterate through the array once. For each element, XOR it with result:

result ^= nums[i];

All duplicate numbers cancel out, and the final value of result is the single number.

# Complexity

- Time complexity: O(n)

- Space complexity: O(1)

# Code

```csharp
public class Solution {
    public int SingleNumber(int[] nums) {
        int result = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        result ^= nums[i];
    }

    return result;
    }
}
```