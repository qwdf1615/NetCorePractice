using Microsoft.AspNetCore.Mvc;

namespace Net6MVC.Controllers
{
    public class CollectionController : Controller
    {
        /// <summary>
        /// 測試兩者效率
        /// </summary>
        /// <returns></returns>
        public IActionResult HashSetAndList()
        {
            return View();
        }


    }
}
