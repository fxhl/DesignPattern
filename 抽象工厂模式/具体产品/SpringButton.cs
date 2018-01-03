using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.抽象产品;
using 抽象工厂模式;
using System.Drawing;
using System.Windows.Forms;

namespace 抽象工厂模式.具体产品
{
    public class SpringButton : IButton
    {
        Button btn = null;
        public SpringButton(Button btn1)
        {
            btn = btn1;
        }
        public void Display()
        {
            btn.BackColor = Color.LightGreen;
        }
    }
}
