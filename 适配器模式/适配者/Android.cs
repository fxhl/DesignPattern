using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 适配器模式.目标抽象类;

namespace 适配器模式.适配者
{
    public class Android
    {
        public virtual void ChongDian()
        {
            MessageBox.Show("安卓手机充电");
        }
    }
}
