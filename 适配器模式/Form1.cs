using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 适配器模式.目标抽象类;
using 适配器模式.适配器;
using 适配器模式.适配者;

namespace 适配器模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            China china  = null;
            if (comboBox1.SelectedIndex==0)
            {
                china = new China();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                china = new AdapterAmerica();
            }
            china.Use();

        }
    }
}
