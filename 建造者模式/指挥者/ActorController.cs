using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.产品;
using 建造者模式.抽象建造者;

namespace 建造者模式.指挥者
{
    public class ActorController
    {
        //逐步构建复杂产品对象
        public Actor Construct(ActorBuilder ab)
        {
            Actor actor;
            ab.BuildType();
            ab.BuildSex();
            ab.BuildFace();
            ab.BuildCostume();
            ab.BuildHairstyle();
            actor = ab.CreateActor();
            return actor;
        }
    }
}
