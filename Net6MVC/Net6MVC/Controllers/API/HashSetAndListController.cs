using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Net6MVC.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashSetAndListController : ControllerBase
    {
        // GET: api/<HashSetAndListController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            Stopwatch sw = new Stopwatch();
            HashSet<TestModel> hs = new HashSet<TestModel>();
            List<TestModel> list = new List<TestModel>();
            HashSet<string> hs2 = new HashSet<string>();
            List<string> list2 = new List<string>();

            // 999,999
            for (int i = 0; i < 999999; i++)
            {
                var model = new TestModel
                {
                    index = i,
                    name = "name-" + i.ToString(),
                };
                hs.Add(model);
                list.Add(model);

                hs2.Add("string-" + i.ToString());
                list2.Add("string-" + i.ToString());
            }

            sw.Reset();
            sw.Start();
            if (hs.Select(s => s.name).Contains("name-45678"))
            {
                var t = 1;
            }

            sw.Stop();

            string result1 = sw.Elapsed.TotalMilliseconds.ToString();

            sw.Reset();
            sw.Start();
            if (list.Select(s => s.name).Contains("name-45678"))
            {
                var t = 1;
            }
            sw.Stop();

            string result2 = sw.Elapsed.TotalMilliseconds.ToString();

            sw.Reset();
            sw.Start();
            if (hs2.Contains("string-67784"))
            {
                var t = 1;
            }
            sw.Stop();

            string result3 = sw.Elapsed.TotalMilliseconds.ToString();

            sw.Reset();
            sw.Start();
            if (list2.Contains("string-67784"))
            {
                var t = 1;
            }
            sw.Stop();

            string result4 = sw.Elapsed.TotalMilliseconds.ToString();

            return new string[] { result1, result2, result3, result4 };
        }

        public class TestModel
        {
            public int index { get; set; }
            public string name { get; set; }
        }
    }
}
