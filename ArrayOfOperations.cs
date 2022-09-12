public class Solution {
    
    public int FinalValueAfterOperations(string[] operations) {
        
        int X = 0;
        foreach(var i in operations)
        {
            switch (i.Contains("--"))
            {
                case true:
                    X--;
                    break;
            
                case false:
                    X++;
                    break;
            
                defaut: 
                    break;
            }
            
        }
        
        return X;
        
    }
    
}
