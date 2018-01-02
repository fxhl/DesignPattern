using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 简单工厂模式.产品;
using 简单工厂模式.接口;

namespace 简单工厂模式.工厂
{
    public class ChartFactory
    {
        public static IChart GetChart(string name)
        {
            IChart chart = null;
            if (string.Equals(name, "0", StringComparison.CurrentCultureIgnoreCase))
            {
                chart = new HistogramChart();
            }
            else if (string.Equals(name, "1", StringComparison.CurrentCultureIgnoreCase))
            {
                chart = new PieChart();
            }
            else if (string.Equals(name, "2", StringComparison.CurrentCultureIgnoreCase))
            {
                chart = new LineChart();
            }
            return chart;
        }
    }
}
