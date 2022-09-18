public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int output = 0;
        for(int i = 0; i < jewels.Length; i++)
        {
             for(int j = 0; j < stones.Length; j++)
            {   
                if(stones[j] == jewels[i]) output++;   
            }
        }
        return output;
    }
}
