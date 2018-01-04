using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 建造者模式.产品
{
    public class Actor
    {
        public string type { get; set; } //角色类型
        public string sex { get; set; } //性别
        public string face { get; set; }//面容
        public string costume { get; set; }//服装
        public string hairstyle { get; set; }//发型
    }
}
