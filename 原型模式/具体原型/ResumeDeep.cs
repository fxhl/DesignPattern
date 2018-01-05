using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式.具体原型
{
    public class ResumeDeep : ICloneable
    {
        private string _name;
        private string _sex;
        private string _age;
        private WorkExperienceDeep _workExperienceDeep;

        public ResumeDeep(string name)
        {
            _name = name;
            _workExperienceDeep = new WorkExperienceDeep();
        }
        public ResumeDeep(WorkExperienceDeep workExperienceDeep)
        {
            _workExperienceDeep = (WorkExperienceDeep)workExperienceDeep.Clone();
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
            _workExperienceDeep.Company = company;
            _workExperienceDeep.WorkDate = workdate;
        }

        public void Display()
        {
            Console.WriteLine("{0},{1},{2}", _name, _age, _sex);
            Console.WriteLine("工作经历:{0},{1}", _workExperienceDeep.WorkDate, _workExperienceDeep.Company);
        }

        public object Clone()
        {
            ResumeDeep obj = new ResumeDeep(this._workExperienceDeep);
            obj._name = this._name;
            obj._age = this._age;
            obj._sex = this._sex;
            return obj;
        }
    }
}
