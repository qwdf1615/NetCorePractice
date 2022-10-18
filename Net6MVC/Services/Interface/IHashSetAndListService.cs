using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interface
{
    public interface IHashSetAndListService
    {
        Task<double> GetRunAddSecond(int count, HashSet<string> hs);
        Task<double> GetRunAddSecond(int count, List<string> hs);
    }
}
