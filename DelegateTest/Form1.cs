using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
    public partial class Test : Form
    {
        //用于显示的文本
        private RichTextBox _tempRichTextBox;
        //用于增加的文本
        private string _addText;
        //声明委托
        private delegate void TestDelegate(string addText, RichTextBox temp);
        //委托变量
        private TestDelegate test { get; set; }
        //调用委托
        private void InvokeDelegate(string addText, RichTextBox temp)
        {
            if (temp != null && temp.InvokeRequired)
            {
                temp.BeginInvoke(this.test, new object[] { addText, temp });
            }
        }

        public Test()
        {
            //窗体屏幕居中显示
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Load += Test_Load;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            testRichTextBox.Text = "吼吼吼，今天！！又是充满希望的一天 \r\n";
        }

        private void textAddBtn_Click(object sender, EventArgs e)
        {
            if (textAddBtn.Text == @"出来吧！！")
            {
                addTextBox.Visible = true;
                hiddenBtn.Visible = true;
                textAddBtn.Text = @"随便写！！";
            }
            else if (textAddBtn.Text == @"随便写！！")
            {
                //全局变量记录控件，新开的线程不是创建控件的线程，不能调用控件
                _tempRichTextBox = this.testRichTextBox;
                _addText = this.addTextBox.Text;
                //新开一个线程，模拟异步
                Thread thread = new Thread(testThread);
                thread.Start();
                //清空用于增加文本的文本框的值
                this.addTextBox.Text = "";
            }
        }

        //测试线程，模拟异步
        private void testThread()
        {
            test = new TestDelegate(AddText);
            InvokeDelegate(_addText, _tempRichTextBox);
        }

        private void AddText(string addText, RichTextBox temp)
        {
            temp.Text += addText + "\r\n";
        }

        private void hiddenBtn_Click(object sender, EventArgs e)
        {
            addTextBox.Text = "";
            addTextBox.Visible = false;
            hiddenBtn.Visible = false;
            textAddBtn.Text = @"出来吧！！";
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EventTestBtn_Click(object sender, EventArgs e)
        {
            EventTest et = new EventTest();
            et.AddTextEvent += new EventTest.DelegateTest(Et_AddTextEvent);
            et.ShowDialog();

            //this.testRichTextBox.Text += et.PubText + "\r\n";
        }

        private void Et_AddTextEvent(string text)
        {
            this.testRichTextBox.Text += text + "\r\n";
        }
    }
}
