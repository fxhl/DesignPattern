using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.抽象建造者;

namespace 建造者模式.具体建造者
{
    public class AngelBuild : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.type = "天使";
        }

        public override void BuildFace()
        {
            actor.sex = "女";
        }

        public override void BuildHairstyle()
        {
            actor.face = "漂亮";
        }

        public override void BuildSex()
        {
            actor.costume = "白裙";
        }

        public override void BuildType()
        {
            actor.hairstyle = "披肩长发";
        }
    }
}
