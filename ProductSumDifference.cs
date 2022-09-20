public class Solution {
    public int SubtractProductAndSum(int n) {
        
        int Sum = 0;
        int Product = 1;
        
        while (n > 0)
        {  
            if (n < 10)
            {
                Sum = Sum + n;
                Product = Product * n;   
            }
            else
            {
                Sum = Sum + (n % 10);
                Product = Product * (n % 10);
            }
             n = n / 10;
        }
        return Product - Sum;
    }
}
