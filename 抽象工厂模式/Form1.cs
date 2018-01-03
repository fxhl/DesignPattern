using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 抽象工厂模式.具体工厂;
using 抽象工厂模式.抽象产品;
using 抽象工厂模式.抽象工厂;

namespace 抽象工厂模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
        private void GetSkin(SkinFactory skinFactory)
        {
            IButton button = skinFactory.CreateButton(button1);
            IComboBox comboBox = skinFactory.CreateComboBox(comboBox1);
            ITextField textField = skinFactory.CreateTextField(textBox1);
            button.Display();
            comboBox.Display();
            textField.Display();
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSkin(new SpingSkinFactory());
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GetSkin(new SummerSkinFactory());
        }
    }
}
