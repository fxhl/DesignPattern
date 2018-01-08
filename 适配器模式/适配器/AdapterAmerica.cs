using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 适配器模式.目标抽象类;
using 适配器模式.适配者;

namespace 适配器模式.适配器
{
    class AdapterAmerica:China
    {
        America america = new America();
        public override void ChongDian()
        {
            america.ChongDian();
        }
    }
}
