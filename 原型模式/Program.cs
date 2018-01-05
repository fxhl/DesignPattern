using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 原型模式.具体原型;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            //浅拷贝
            ShallowClone();
            //深复制
            ShallowDeep();

            Console.ReadKey();
        }
        /// <summary>
        /// 深复制
        /// </summary>
        static void ShallowDeep()
        {
            ResumeDeep resumeA = new ResumeDeep("大鸟");
            resumeA.SetPersonalInfo("29", "男");
            resumeA.SetWorkExperience("xx公司", "1998-2000");

            ResumeDeep resumeB = (ResumeDeep)resumeA.Clone();
            resumeB.SetWorkExperience("yy公司", "1998-2006");

            resumeA.Display();
            resumeB.Display();
        }

        /// <summary>
        /// 浅复制
        /// </summary>
        static void ShallowClone()
        {
            ResumeShallow resumeA = new ResumeShallow("大鸟");
            resumeA.SetPersonalInfo("29", "男");
            resumeA.SetWorkExperience("xx公司", "1998-2000");

            ResumeShallow resumeB = (ResumeShallow)resumeA.Clone();
            resumeB.SetWorkExperience("yy公司", "1998-2006");

            resumeA.Display();
            resumeB.Display();
        }
    }
}
