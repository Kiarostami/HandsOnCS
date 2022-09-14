public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int max = 0;
        int holder = 0;
        
        for(int i = 0; i < accounts.Length; i++)
        {
            for(int j = 0; j < accounts[i].Length; j++)
            {
                holder = holder + accounts[i][j];    
            }   
            if (holder >= max)
            {
                max = holder;
            }
            holder = 0;
        }
        return max;
    }
}
