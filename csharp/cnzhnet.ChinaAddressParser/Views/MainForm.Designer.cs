
namespace cnzhnet.ChinaAddressParser.Views
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.parserTestControl1 = new cnzhnet.ChinaAddressParser.Views.ParserTestControl();
            this.sourceCodeGenerator1 = new cnzhnet.ChinaAddressParser.Views.SourceCodeGenerator();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(699, 498);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.parserTestControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(691, 468);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "智能解析测试";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.sourceCodeGenerator1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(691, 468);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "源代码生成";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // parserTestControl1
            // 
            this.parserTestControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parserTestControl1.Location = new System.Drawing.Point(3, 3);
            this.parserTestControl1.Name = "parserTestControl1";
            this.parserTestControl1.Size = new System.Drawing.Size(685, 462);
            this.parserTestControl1.TabIndex = 0;
            // 
            // sourceCodeGenerator1
            // 
            this.sourceCodeGenerator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceCodeGenerator1.Location = new System.Drawing.Point(3, 3);
            this.sourceCodeGenerator1.Name = "sourceCodeGenerator1";
            this.sourceCodeGenerator1.Size = new System.Drawing.Size(685, 462);
            this.sourceCodeGenerator1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "中华人民共和国智能地址解析";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ParserTestControl parserTestControl1;
        private SourceCodeGenerator sourceCodeGenerator1;
    }
}

