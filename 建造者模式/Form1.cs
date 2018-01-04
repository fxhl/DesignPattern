using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 建造者模式.产品;
using 建造者模式.具体建造者;
using 建造者模式.指挥者;

namespace 建造者模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ActorController actorController = new ActorController();
            Actor actor = null;
            if (radioButton1.Checked)
            {
               actor= actorController.Construct(new AngelBuild());
            }
            else if (radioButton2.Checked)
            {
                actor = actorController.Construct(new DevilBuilder());
            }
            else if (radioButton3.Checked)
            {
                actor = actorController.Construct(new HeroBuilder());
            }
            else
            {
                throw new Exception("没有找到指定角色");
            }
            MessageBox.Show(string.Format("{0}的外观：\n性别：{1}\n面容：{2}\n服装：{3}\n发型:{4}", actor.type, actor.sex, actor.face, actor.costume, actor.hairstyle));
        }
    }
}
