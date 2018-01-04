﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 建造者模式.抽象建造者;

namespace 建造者模式.具体建造者
{
    public class HeroBuilder : ActorBuilder
    {
        public override void BuildCostume()
        {
            actor.type = "英雄";
        }

        public override void BuildFace()
        {
            actor.sex = "男";
        }

        public override void BuildHairstyle()
        {
            actor.face = "英俊";
        }

        public override void BuildSex()
        {
            actor.costume = "盔甲";
        }

        public override void BuildType()
        {
            actor.hairstyle = "飘逸";
        }
    }
}
