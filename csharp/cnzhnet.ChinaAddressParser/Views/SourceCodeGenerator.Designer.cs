
namespace cnzhnet.ChinaAddressParser.Views
{
    partial class SourceCodeGenerator
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
                openFileDialog.Dispose();
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.generateButton = new System.Windows.Forms.Button();
            this.radioGenerateKotlin = new System.Windows.Forms.RadioButton();
            this.radioGenerateCsharp = new System.Windows.Forms.RadioButton();
            this.browserButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateButton);
            this.panel1.Controls.Add(this.radioGenerateKotlin);
            this.panel1.Controls.Add(this.radioGenerateCsharp);
            this.panel1.Controls.Add(this.browserButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 79);
            this.panel1.TabIndex = 2;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.Location = new System.Drawing.Point(525, 42);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 25);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "生成(&G)";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // radioGenerateKotlin
            // 
            this.radioGenerateKotlin.AutoSize = true;
            this.radioGenerateKotlin.Location = new System.Drawing.Point(255, 45);
            this.radioGenerateKotlin.Name = "radioGenerateKotlin";
            this.radioGenerateKotlin.Size = new System.Drawing.Size(154, 21);
            this.radioGenerateKotlin.TabIndex = 4;
            this.radioGenerateKotlin.Text = "生成 Kotlin 的字典定义.";
            this.radioGenerateKotlin.UseVisualStyleBackColor = true;
            // 
            // radioGenerateCsharp
            // 
            this.radioGenerateCsharp.AutoSize = true;
            this.radioGenerateCsharp.Checked = true;
            this.radioGenerateCsharp.Location = new System.Drawing.Point(88, 45);
            this.radioGenerateCsharp.Name = "radioGenerateCsharp";
            this.radioGenerateCsharp.Size = new System.Drawing.Size(137, 21);
            this.radioGenerateCsharp.TabIndex = 3;
            this.radioGenerateCsharp.TabStop = true;
            this.radioGenerateCsharp.Text = "生成 C# 的字典定义.";
            this.radioGenerateCsharp.UseVisualStyleBackColor = true;
            // 
            // browserButton
            // 
            this.browserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browserButton.Location = new System.Drawing.Point(525, 6);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(75, 25);
            this.browserButton.TabIndex = 2;
            this.browserButton.Text = "浏览(&B)";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.OnButtonClick);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(88, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据文件：";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 79);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(612, 370);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // SourceCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Name = "SourceCodeGenerator";
            this.Size = new System.Drawing.Size(612, 449);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RadioButton radioGenerateKotlin;
        private System.Windows.Forms.RadioButton radioGenerateCsharp;
    }
}
