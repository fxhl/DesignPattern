using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式.具体原型
{
    public class ResumeShallow : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperienceShallow _experience;//浅复制

        public ResumeShallow(string name)
        {
            _name = name;
            _experience = new WorkExperienceShallow();
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        public void SetPersonalInfo(string age, string sex)
        {
            _sex = sex;
            _age = age;
        }
        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="company"></param>
        /// <param name="workdate"></param>
        public void SetWorkExperience(string company, string workdate)
        {
            _experience.Company = company;
            _experience.WorkDate = workdate;
        }

        public void Display()
        {
            Console.WriteLine("{0},{1},{2}",_name,_age,_sex);
            Console.WriteLine("工作经历:{0},{1}", _experience.WorkDate, _experience.Company);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
