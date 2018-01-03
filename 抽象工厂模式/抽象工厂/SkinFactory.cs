using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抽象工厂模式.抽象产品;

namespace 抽象工厂模式.抽象工厂
{
    public interface SkinFactory
    {
        IButton CreateButton(Button button);
        IComboBox CreateComboBox(ComboBox comboBox );
        ITextField CreateTextField(TextBox textBox );
    }
}
