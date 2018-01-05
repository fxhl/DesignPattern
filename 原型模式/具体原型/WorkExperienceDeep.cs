using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式.具体原型
{
    public class WorkExperienceDeep : ICloneable
    {
        public string WorkDate { get; set; }
        public string Company { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
