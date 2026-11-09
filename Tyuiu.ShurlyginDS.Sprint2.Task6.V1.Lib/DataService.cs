using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShurlyginDS.Sprint2.Task6.V1.Lib
{
    public class DataService : ISprint2Task6V1
    {
        public int FindMonthDaysCount(int value)
        {
            int res = value switch
            {
                2 => 28,
                4 or 6 or 9 or 11 => 30,
                1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                _ => throw new ArgumentException("Некорректный номер месяца")
            };

            return res;
        }   
        
    }
}
