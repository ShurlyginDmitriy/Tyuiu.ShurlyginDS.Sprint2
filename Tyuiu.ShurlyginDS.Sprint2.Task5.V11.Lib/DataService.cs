using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShurlyginDS.Sprint2.Task5.V11.Lib
{
    public class DataService : ISprint2Task5V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int lastDay;

            
            switch (m)
            {
                case 2:
                    lastDay = 28; 
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    lastDay = 30;
                    break;
                default:
                    lastDay = 31;
                    break;
            }

            if (n < lastDay)
            {
                n++; 
            }
            else
            {
                n = 1; 
                if (m < 12)
                {
                    m++; 
                }
                else
                {
                    m = 1; 
                    g++; 
                }
            }
            string day = n < 10 ? "0" + n : n.ToString();
            string month = m < 10 ? "0" + m : m.ToString();

            string res = $"{day}.{month}.{g}";
            return res;
        }
    }
}
 