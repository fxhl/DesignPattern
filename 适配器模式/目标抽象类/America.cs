using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 适配器模式.目标抽象类
{
    class America 
    {
        public void ChongDian()
        {
            MessageBox.Show("110V电器");
        }
    }
}
