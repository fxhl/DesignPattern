using System;
using System.Configuration;
using System.Reflection;
using 工厂方法模式.抽象产品;
using 工厂方法模式.抽象工厂;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            string factoryString = ConfigurationManager.AppSettings["loggerType"];
            ILoggerFactory logger =(ILoggerFactory) Assembly.Load("工厂方法模式").CreateInstance(factoryString);
            ILogger log= logger.CreateLogger();
            Console.WriteLine(log.WriteLog());
            Console.ReadKey();
        }
    }
}
