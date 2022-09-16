public class Solution {
    public int MostWordsFound(string[] sentences) {
        int MaxWords = 0;
        int Holder = 0;
        for(int i = 0; i < sentences.Count(); i++)
        {
            foreach(char c in sentences[i])
            {
                if(c == ' ')
                {
                  Holder++;
                }
            }
             Holder++;
            if(Holder > MaxWords)
            {
                MaxWords = Holder;
            }
            Holder = 0;
        }
        return MaxWords;
    }
}
