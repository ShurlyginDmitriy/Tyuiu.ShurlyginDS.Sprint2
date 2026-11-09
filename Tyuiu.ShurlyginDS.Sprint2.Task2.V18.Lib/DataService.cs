using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShurlyginDS.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 4 && y >= 3 && y <= 5) ||
                (x == 5 && y >= 3 && y <= 8) ||
                (x >= 6 && x <= 7 && y >= 5 && y <= 8) ||
                (x >= 2 && x <= 6 && y >= 6 && y <= 7) ||
                (x == 6 && y >= 9 && y <= 10) ||
                (x >= 3 && x <= 6 && y >= 10 && y <= 11) ||
                (x == 7 && y >= 11 && y <= 12) ||
                (x >= 12 && x <= 13 && y >= 3 && y <= 6) ||
                (x >= 6 && x <= 8 && y >= 8 && y <= 9))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
