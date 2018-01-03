using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抽象工厂模式.具体产品;
using 抽象工厂模式.抽象产品;
using 抽象工厂模式.抽象工厂;

namespace 抽象工厂模式.具体工厂
{
    public class SummerSkinFactory : SkinFactory
    {
        public IButton CreateButton(Button button)
        {
            return new SummerButton(button);
        }

        public IComboBox CreateComboBox(ComboBox comboBox)
        {
            return new SummerCombox(comboBox);
        }

        public ITextField CreateTextField(TextBox textBox)
        {
            return new SummerTextField(textBox);
        }
    }
}
