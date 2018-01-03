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
    public class SpringTextField : ITextField
    {
        TextBox tb = null;
        public SpringTextField(TextBox tb)
        {
            this.tb = tb;
        }
        public void Display()
        {
            tb.BackColor = Color.LightGreen;
        }
    }
}
