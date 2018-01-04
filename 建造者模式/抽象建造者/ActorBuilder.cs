using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.产品;

namespace 建造者模式.抽象建造者
{
    /// <summary>
    /// 角色建造者
    /// </summary>
    public abstract class ActorBuilder
    {
        protected Actor actor = new Actor();

        public abstract void BuildType();
        public abstract void BuildSex();
        public abstract void BuildFace();
        public abstract void BuildCostume();
        public abstract void BuildHairstyle();
        /// <summary>
        /// 创建角色
        /// </summary>
        /// <returns>角色对象</returns>
        public Actor CreateActor()
        {
            return actor;
        }

    }
}
