using Microsoft.AspNetCore.Mvc;
using Net6MVC.Logic;
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
            int FirstCount = 3;
            int SecondCount = 300;
            int Count = 30000;

            HashSetAndListLogic hashSetAndListLogic = new HashSetAndListLogic();
            HashSet<string> hs = new HashSet<string>();
            List<string> list = new List<string>();

            string result1 = hashSetAndListLogic.GetRunAddSecond(FirstCount, hs).ToString();
            result1 += "、" + hashSetAndListLogic.GetRunAddSecond(SecondCount, hs).ToString();
            result1 += "、" + hashSetAndListLogic.GetRunAddSecond(Count, hs).ToString();

            string result2 = hashSetAndListLogic.GetRunAddSecond(FirstCount, list).ToString();
            result2 += "、" + hashSetAndListLogic.GetRunAddSecond(SecondCount, list).ToString();
            result2 += "、" + hashSetAndListLogic.GetRunAddSecond(Count, list).ToString();

            return new string[] { result1, result2 };
        }
    }
}
