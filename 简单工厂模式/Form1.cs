using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 简单工厂模式.工厂;
using 简单工厂模式.接口;

namespace 简单工厂模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
        }

        /// <summary>
        /// 查看报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            IChart chart= ChartFactory.GetChart(comboBox1.SelectedIndex.ToString());
            MessageBox.Show(chart.Display());
        }
    }
}
