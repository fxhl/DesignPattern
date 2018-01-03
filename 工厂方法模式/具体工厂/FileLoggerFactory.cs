using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 工厂方法模式.具体产品;
using 工厂方法模式.抽象产品;
using 工厂方法模式.抽象工厂;

namespace 工厂方法模式.具体工厂
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //创建文件日志记录器对象
            //创建文件
            return new FileLogger();
        }
    }
}
