namespace DelegateTest
{
    partial class Test
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.testRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textAddBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.hiddenBtn = new System.Windows.Forms.Button();
            this.EventTestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testRichTextBox
            // 
            this.testRichTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.testRichTextBox.Location = new System.Drawing.Point(36, 42);
            this.testRichTextBox.Name = "testRichTextBox";
            this.testRichTextBox.ReadOnly = true;
            this.testRichTextBox.Size = new System.Drawing.Size(405, 178);
            this.testRichTextBox.TabIndex = 0;
            this.testRichTextBox.Text = "";
            // 
            // textAddBtn
            // 
            this.textAddBtn.Location = new System.Drawing.Point(83, 276);
            this.textAddBtn.Name = "textAddBtn";
            this.textAddBtn.Size = new System.Drawing.Size(100, 30);
            this.textAddBtn.TabIndex = 1;
            this.textAddBtn.Text = "出来吧！！";
            this.textAddBtn.UseVisualStyleBackColor = true;
            this.textAddBtn.Click += new System.EventHandler(this.textAddBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(273, 276);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(100, 30);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "溜了溜了！！";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(36, 242);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(347, 21);
            this.addTextBox.TabIndex = 3;
            this.addTextBox.Visible = false;
            // 
            // hiddenBtn
            // 
            this.hiddenBtn.Location = new System.Drawing.Point(389, 242);
            this.hiddenBtn.Name = "hiddenBtn";
            this.hiddenBtn.Size = new System.Drawing.Size(52, 23);
            this.hiddenBtn.TabIndex = 4;
            this.hiddenBtn.Text = "bye";
            this.hiddenBtn.UseVisualStyleBackColor = true;
            this.hiddenBtn.Visible = false;
            this.hiddenBtn.Click += new System.EventHandler(this.hiddenBtn_Click);
            // 
            // EventTestBtn
            // 
            this.EventTestBtn.Location = new System.Drawing.Point(157, 323);
            this.EventTestBtn.Name = "EventTestBtn";
            this.EventTestBtn.Size = new System.Drawing.Size(145, 26);
            this.EventTestBtn.TabIndex = 5;
            this.EventTestBtn.Text = "事件触发";
            this.EventTestBtn.UseVisualStyleBackColor = true;
            this.EventTestBtn.Click += new System.EventHandler(this.EventTestBtn_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.EventTestBtn);
            this.Controls.Add(this.hiddenBtn);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textAddBtn);
            this.Controls.Add(this.testRichTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.Text = "吼哈哈";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox testRichTextBox;
        private System.Windows.Forms.Button textAddBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button hiddenBtn;
        private System.Windows.Forms.Button EventTestBtn;
    }
}

