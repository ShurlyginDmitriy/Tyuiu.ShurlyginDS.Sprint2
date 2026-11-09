using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShurlyginDS.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if (((Math.Pow(x,2) + Math.Pow(y, 2) <= 1) && (x <= 0)) || ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && (x >= 0 && y >= 0 && y <= x)))
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
