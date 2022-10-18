using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Interface;

namespace Net6MVC.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashSetAndListController : BaseController
    {
        private readonly IHashSetAndListService _hashSetAndListService;
        public HashSetAndListController(IHashSetAndListService hashSetAndListService) 
        {
            _hashSetAndListService = hashSetAndListService;
        }

        // GET: api/<HashSetAndListController>
        [HttpGet]
        public async Task<IEnumerable<string>> Get()
        {
            int FirstCount = 3;
            int SecondCount = 300;
            int Count = 30000;

            HashSet<string> hs = new HashSet<string>();
            List<string> list = new List<string>();

            var r1 = await _hashSetAndListService.GetRunAddSecond(FirstCount, hs);
            var r2 = await _hashSetAndListService.GetRunAddSecond(SecondCount, hs);
            var r3 = await _hashSetAndListService.GetRunAddSecond(Count, hs);
            var r4 = await _hashSetAndListService.GetRunAddSecond(FirstCount, list);
            var r5 = await _hashSetAndListService.GetRunAddSecond(SecondCount, list);
            var r6 = await _hashSetAndListService.GetRunAddSecond(Count, list);

            string result1 = r1.ToString();
            result1 += "、" + r2.ToString();
            result1 += "、" + r3.ToString();

            string result2 = r4.ToString();
            result2 += "、" + r5.ToString();
            result2 += "、" + r6.ToString();

            return new string[] { result1, result2 };
        }
    }
}
