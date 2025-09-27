using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ZakachurinIE.Sprint1.Task5.V4.Lib
{
    public class DataService : ISprint1Task5V4
    {
        public int SecondsToHours(int time)
        {
            if (time <= 3600) return 0;
            else
            {
                return (time / 3600);
            }
        }
    }
}
