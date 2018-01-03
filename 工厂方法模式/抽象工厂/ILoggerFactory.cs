using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 工厂方法模式.抽象产品;

namespace 工厂方法模式.抽象工厂
{
    public interface ILoggerFactory
    {
        ILogger CreateLogger();
    }
}
