using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 简单工厂模式.Interface;

namespace 简单工厂模式.chart
{
    public class LineChart : IChart
    {
        public string Display()
        {
            return "显示折线图";
        }
    }
}
