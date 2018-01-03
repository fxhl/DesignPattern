using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 工厂方法模式.抽象产品;

namespace 工厂方法模式.具体产品
{
    public class FileLogger : ILogger
    {
        public string WriteLog()
        {
            return "日志记录在磁盘中";
        }
    }
}
