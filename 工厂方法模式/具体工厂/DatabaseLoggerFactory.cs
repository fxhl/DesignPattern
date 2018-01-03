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
    class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            //进行连接数据库日志记录信息
            ILogger logger = new DatabaseLogger();
            return logger;
        }
    }
}
