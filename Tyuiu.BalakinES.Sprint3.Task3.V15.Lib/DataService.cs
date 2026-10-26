using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BalakinES.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;
            int minCount = 10;
            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
                else
                {
                    if (count >= 1)
                    {
                        if (count < minCount)
                        {
                            minCount = count;
                        }
                    }
                    count = 0;
                }
                
            }
            return minCount;
        }
    }
}
