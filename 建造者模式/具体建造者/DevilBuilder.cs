using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.抽象建造者;

namespace 建造者模式.具体建造者
{
    public class DevilBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.type = "恶魔";
        }

        public override void BuildFace()
        {
            actor.sex = "妖";
        }

        public override void BuildHairstyle()
        {
            actor.face = "丑陋";
        }

        public override void BuildSex()
        {
            actor.costume = "黑衣";
        }

        public override void BuildType()
        {
            actor.hairstyle = "光头";
        }
    }
}
