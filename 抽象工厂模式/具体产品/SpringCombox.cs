﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抽象工厂模式.抽象产品;

namespace 抽象工厂模式.具体产品
{
    public class SpringCombox : IComboBox
    {
        ComboBox cb = null;
        public SpringCombox(ComboBox cb1)
        {
            this.cb = cb1;
        }
        public void Display()
        {
            cb.BackColor = Color.LightGreen;
        }
    }
}
