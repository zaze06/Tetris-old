using System;
namespace tetris
{
    public class Util
    {
        public static void wait(int time)
        {
            DateTime timeToEnd = DateTime.Now.AddSeconds(time);
            //timeToEnd = timeToEnd.AddSeconds(time);
            DateTime now = DateTime.Now;
            while (timeToSring(now.Hour, now.Minute, now.Second) != timeToSring(timeToEnd.Hour, timeToEnd.Minute, timeToEnd.Second)) {
                now = DateTime.Now;
            }
        }
        public static string timeToSring(int H, int M, int S)
        {
            return H + ":" + M + ":" + S;
        }
        public static string timeToSring(){
            DateTime now = DateTime.Now;
            return timeToSring(now.Hour, now.Minute, now.Second);
        }
    }
}