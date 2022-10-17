using System.Diagnostics;

namespace Net6MVC.Logic
{
    public class HashSetAndListLogic
    {
        public double GetRunAddSecond(int count, HashSet<string> hs)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                if (!hs.Contains(i.ToString()))
                    hs.Add("string-" + i);
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public double GetRunAddSecond(int count, List<string> hs)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < count; i++)
            {
                if (!hs.Contains(i.ToString()))
                    hs.Add("string-" + i);
            }
            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
