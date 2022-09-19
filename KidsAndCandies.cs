public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        List<bool> results = new List<bool>();
        for (int i = 0; i < candies.Length; i++)
        {
            if (candies[i] + extraCandies >= candies.Max()) results.Add(true);
            else results.Add(false);
        }
        return results;
    }
}
