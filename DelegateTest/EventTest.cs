using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateTest
{
    public partial class EventTest : Form
    {
        //public string PubText { get; set; }
        public delegate void DelegateTest(string text);

        public event DelegateTest AddTextEvent;
        public EventTest()
        {
            //窗体屏幕居中显示
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void addForMainText_GotFocus(object sender, EventArgs e)
        {
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            label1.Text = "只可以输入汉字";
        }

        private void addForMainText_LostFocus(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var text = addForMainText.Text;
            //校验
            //文本框为空或空格时
            if (string.IsNullOrWhiteSpace(text))
            {
                label1.Text = "不可以为空哦";
                label1.ForeColor = System.Drawing.Color.Red;
                return;
            }
            else
            {
                //正则表达式校验汉字
                var pattern = "^[\u4E00-\u9FA5\\s]+$";
                if (!Regex.IsMatch(text, pattern))
                {
                    label1.Text = "都说了只能输入汉字！！";
                    label1.ForeColor = System.Drawing.Color.Red;
                    return;
                }
            }

            //PubText = text;
            //强行写事件。。。。
            AddTextEvent?.Invoke(text);
            Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
