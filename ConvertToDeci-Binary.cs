public class Solution {
    public int MinPartitions(string n) {
        
        /*
        if (Number % (Math.Pow(10, n.Length()-1)) == 0)
        {
                
            return n.Length();
            
        }
        */
        
        /*
        ans = Convert.ToInt32(Number / Math.Pow(10,  n.Length-1));
        for (int i = 1; i <  n.Length; i++)
        {
            if(n[i] > ans) 
            {
                ans = ans + (n[i]-n[i-1]);
            }
        }
        return ans;
        */
        
        int[] num = new int[n.Length];
        for (int i = 0; i <  n.Length; i++)
        {
            num[i] = n[i] - '0';
        }
        return num.Max();
    }
}
