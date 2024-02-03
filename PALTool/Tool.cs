using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 幻兽帕鲁工具
{
    public static class Tool
    {

        public static Pal? SearchPal(this string Name, List<Pal> pals) =>
             pals.Find(d => d.Name.Replace(" ", "") == Name.Replace(" ",""));

    }
}
