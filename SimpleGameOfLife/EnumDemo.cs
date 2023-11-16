namespace SimpleGameOfLife
{
    internal class EnumDemo
    {
        static void Run()
        {
            var aDay = Weekday.Torsdag;
            int aDayAsInt = (int)aDay;
            var anotherDay = (Weekday)5;
            aDay++;
        }
    }
}
