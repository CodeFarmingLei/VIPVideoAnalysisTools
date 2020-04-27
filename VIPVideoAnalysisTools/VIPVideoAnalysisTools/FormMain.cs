using System;
using System.Collections;
using System.Windows.Forms;

namespace VIPVideoAnalysisTools
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AddComboBox();  //填充数据
            //默认网址文本框内容显示为第一个网站的value值
            this.textBoxVideoLink.Text = comboBoxVideoLink.SelectedValue.ToString();
        }

        /// <summary>
        /// 解析链接地址并播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(comboBoxInterface.SelectedValue + textBoxLink.Text);
        }

        /// <summary>
        /// 使用浏览器访问此网站
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOpenVideoLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(comboBoxVideoLink.SelectedValue + textBoxLink.Text);
        }

        /// <summary>
        /// 视频网站选择改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxVideoLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBoxVideoLink.Text = comboBoxVideoLink.SelectedValue.ToString();
        }

        /// <summary>
        /// 初始化填充comboBox数据
        /// </summary>
        public void AddComboBox()
        {
            //填充接口数据
            ArrayList Interfacelist = new ArrayList();
            Interfacelist.Add(new Link("vip超清视频解析【全网vip解析】", "https://jx.idc126.net/jx/?url="));
            Interfacelist.Add(new Link("basc接口【全网vip解析】", "http://beaacc.com/api.php?url="));
            Interfacelist.Add(new Link("1号通用vip引擎系统【稳定通用】", "http://jx.598110.com/?url="));
            Interfacelist.Add(new Link("2号通用vip引擎系统【稳定通用】", "http://vip.jlsprh.com/?url="));
            Interfacelist.Add(new Link("3号通用vip引擎系统【稳定通用】", "http://jx.618ge.com/?url="));
            Interfacelist.Add(new Link("4号通用vip引擎系统【稳定通用】", "http://jx.drgxj.com/?url="));
            Interfacelist.Add(new Link("5号通用vip引擎系统【稳定通用】", "http://jx.du2.cc/?url="));
            Interfacelist.Add(new Link("无广告超速解析【通用】", "http://jx.drgxj.com/?url="));

            //填充接口选择控件
            comboBoxInterface.Items.Clear();                                //清空combobox
            comboBoxInterface.DataSource = Interfacelist;           //将lst列表绑定到combobx
            comboBoxInterface.DisplayMember = "LinkName";     //指定显示的数据项
            comboBoxInterface.ValueMember = "LinkSrc";            //comboBoxInterface.SelectedValue返回的数据项

            //填充网站链接数据
            ArrayList VideoLinklist = new ArrayList();
            VideoLinklist.Add(new Link("优酷视频", "https://www.youku.com/"));
            VideoLinklist.Add(new Link("爱奇艺视频", "https://www.iqiyi.com/"));
            VideoLinklist.Add(new Link("腾讯视频", "https://v.qq.com/"));
            VideoLinklist.Add(new Link("搜狐视频", "https://tv.sohu.com/"));
            VideoLinklist.Add(new Link("乐视视频", "https://www.le.com/"));
            VideoLinklist.Add(new Link("西瓜视频", "https://www.ixigua.com/"));
            VideoLinklist.Add(new Link("芒果TV", "https://www.mgtv.com/"));
            VideoLinklist.Add(new Link("华数TV", "https://www.wasu.com/"));
            VideoLinklist.Add(new Link("土豆网", "https://www.tudou.com/"));
            VideoLinklist.Add(new Link("56网", "https://www.56.com/"));
            VideoLinklist.Add(new Link("酷6网", "https://www.ku6.com/"));
            VideoLinklist.Add(new Link("bilibili弹幕视频网", "https://www.bilibili.com/"));
            VideoLinklist.Add(new Link("AcFun弹幕视频网", "https://www.acfun.cn/"));

            //填充接口选择控件
            comboBoxVideoLink.Items.Clear();                                //清空combobox
            comboBoxVideoLink.DataSource = VideoLinklist;          //将lst列表绑定到combobx
            comboBoxVideoLink.DisplayMember = "LinkName";     //指定显示的数据项
            comboBoxVideoLink.ValueMember = "LinkSrc";            //comboBoxInterface.SelectedValue返回的数据项
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 窗口置顶事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripButtonTop_Click(object sender, EventArgs e)
        {
            if (toolStripButtonTop.Text == "窗口置顶")
            {
                toolStripButtonTop.Text = "取消窗口置顶";
                this.TopMost = true;
            }
            else if (toolStripButtonTop.Text == "取消窗口置顶")
            {
                toolStripButtonTop.Text = "窗口置顶";
                this.TopMost = false;
            }
        }

        
    }
}
