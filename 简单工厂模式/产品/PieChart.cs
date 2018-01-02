using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 简单工厂模式.接口;

namespace 简单工厂模式.产品
{
    public class PieChart : IChart
    {
        public string Display()
        {
            return "显示饼状图";
        }
    }
}
