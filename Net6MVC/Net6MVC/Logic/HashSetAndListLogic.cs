using System.Diagnostics;

namespace Net6MVC.Logic
{
    public class HashSetAndListLogic
    {
        public async Task<double> GetRunAddSecond(int count, HashSet<string> hs)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            await Task.Run(() =>
            {                
                for (int i = 0; i < count; i++)
                {
                    if (!hs.Contains(i.ToString()))
                        hs.Add("string-" + i);
                }                
            });

            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }

        public async Task<double> GetRunAddSecond(int count, List<string> hs)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    if (!hs.Contains(i.ToString()))
                        hs.Add("string-" + i);
                }
            });

            sw.Stop();
            return sw.Elapsed.TotalMilliseconds;
        }
    }
}
