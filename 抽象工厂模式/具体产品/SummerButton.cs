using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抽象工厂模式.抽象产品;

namespace 抽象工厂模式.具体产品
{
    public class SummerButton : IButton
    {
        Button btn = null;
        public SummerButton(Button btn1)
        {
            btn = btn1;
        }
        public void Display()
        {
            btn.BackColor = Color.LightBlue;
        }
    }
}
