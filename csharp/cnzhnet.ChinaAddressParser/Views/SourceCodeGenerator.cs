using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cnzhnet.ChinaAddressParser.Views
{
    /// <summary>
    /// 表示行政区划数据的字典源代码生成器.
    /// </summary>
    public partial class SourceCodeGenerator : UserControl
    {
        private const string name_pattern = @"^\s*\'name\'\s*\=\>\s*";
        private const string pid_pattern = @"^\s*\'pid\'\s*\=\>\s*";
        private const string zipcode_pattern = @"^\s*\'zipcode\'\s*\=\>\s*";

        private OpenFileDialog openFileDialog;
        private SynchronizationContext context;
        private List<RegionDivision> divisions;

        /// <summary>
        /// 创建一个 <see cref="SourceCodeGenerator"/> 的对象实例.
        /// </summary>
        public SourceCodeGenerator()
        {
            InitializeComponent();

            openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "选择行政区划的数据文件";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            openFileDialog.Filter = "PHP源文件(*.php)|*.php";
            openFileDialog.Multiselect = false;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            context = SynchronizationContext.Current;
        }

        /// <summary>
        /// 打开行政区划数据文件（将启动一个任务线程）.
        /// </summary>
        private void OpenFile()
        {
            openFileDialog.FileName = string.Empty;
            switch (openFileDialog.ShowDialog(this))
            {
                case DialogResult.Cancel:
                case DialogResult.No:
                    return;
            }
            string filePath = textBox1.Text = openFileDialog.FileName;
            panel1.Enabled = false;
            richTextBox1.Text = "\r\n正在解析 PHP 源代码中的数据定义.";
            Task.Factory.StartNew(() => {
                divisions?.Clear();
                divisions = new List<RegionDivision>();
                int parsingId = -1;
                try
                {
                    // 以文本方式读取 PHP 源代码文件，分析找出其中的行政区划数据定义.
                    using (TextReader reader = new StreamReader(filePath, Encoding.UTF8))
                    {
                        string line;
                        RegionDivision division;
                        Match m;
                        string[] itemMembers;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (string.IsNullOrEmpty(line))
                                continue;
                            // 检测 PHP 代码行中的数组元素定义.
                            m = Regex.Match(line, @"^\s*\'\d+\'\s*\=\>", RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                            if (m == null || string.IsNullOrEmpty(m.Value))
                                continue; //该行中不包含 PHP 数组元素的定义则忽略.
                            division = new RegionDivision();
                            division.id = Convert.ToInt32(Regex.Match(m.Value, @"\d+").Value);
                            parsingId = division.id;
                            line = line.Replace(m.Value, string.Empty).Replace("array(", string.Empty).Replace(")", string.Empty).Trim();
                            itemMembers = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            PhpArrayItemParse(itemMembers, division);
                            divisions.Add(division);
                        }
                    }
                    context.Send((state) => { richTextBox1.Text = $"成功从 PHP 源代码中解析 {divisions.Count} 条数据定义.\r\n请点击“生成”按钮来生成目标源代码的定义！"; }, null);
                }
                catch (Exception Ex)
                {
                    divisions.Clear();
                    context.Send((state) => { richTextBox1.Text = $"{Ex.Message} 行{parsingId}\r\n{Ex.StackTrace}"; }, null);
                }
                context.Send((state) => { panel1.Enabled = true; }, null);
            });
        }

        private void PhpArrayItemParse(string[] members, RegionDivision division)
        {
            Match mm;
            foreach (string s in members)
            {
                mm = Regex.Match(s, name_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                // 解析行政区划名称.
                if (mm != null && !string.IsNullOrEmpty(mm.Value))
                {
                    division.name = s.Replace(mm.Value, string.Empty);
                    division.name = division.name.Substring(1, division.name.Length - 2);
                    continue;
                }
                // 解析父级 ID.
                mm = Regex.Match(s, pid_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                if (mm != null && !string.IsNullOrEmpty(mm.Value))
                {
                    division.pid = Convert.ToInt32(s.Replace(mm.Value, string.Empty).Trim());
                    continue;
                }
                // 解析邮编．
                mm = Regex.Match(s, zipcode_pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
                if (mm != null && !string.IsNullOrEmpty(mm.Value))
                {
                    try
                    {
                        division.zipCode = Convert.ToInt64(s.Replace(mm.Value, string.Empty).Trim());
                    }
                    catch { division.zipCode = 0; }
                }
            }
        }

        private void GenerateCsharp()
        {
            context.Send((state) => { richTextBox1.Text = "正在生成 C# 的定义源代码..."; }, null);
            StringBuilder codeBuilder = new StringBuilder("[Serializable()]\r\npublic class RegionDivision\r\n");
            codeBuilder.Append("{\r\n\t").Append("public int id { get; set; }");
            codeBuilder.Append("\r\n\t").Append("public int pid { get; set; }");
            codeBuilder.Append("\r\n\t").Append("public string name { get; set; }");
            codeBuilder.Append("\r\n\t").Append("public long zipCode { get; set; }");
            codeBuilder.Append("\r\n\r\n\t").Append("public RegionDivision(int _id, int _pid, string _name, long _zipcode = 0)");
            codeBuilder.Append("\r\n\t{");
            codeBuilder.Append("\r\n\t\tid = _id;\r\n\t\tpid = _pid;\r\n\t\tname = _name;\r\n\t\tzipCode = _sipcode;");
            codeBuilder.Append("\r\n\t}");
            codeBuilder.Append("\r\n\r\n\t").Append("public RegionDivision() : this(_id: -1, _pid: -1, _name: null)");
            codeBuilder.Append("\r\n\t{ }");
            codeBuilder.Append("\r\n}\r\n");
            codeBuilder.AppendLine("//---------------------------------");
            codeBuilder.AppendLine("Dictionary<int, RegionDivision> divisions = new Dictionary<int, RegionDivision>();");
            foreach (RegionDivision rd in divisions)
                codeBuilder.AppendLine($"level.Add({rd.id}, new RegionDivision({rd.id}, {rd.pid}, \"{rd.name}\", {rd.zipCode}));");
            context.Send((state) => { 
                richTextBox1.Text = codeBuilder.ToString();
                panel1.Enabled = true;
            }, null);
        }

        private void GenerateKotlin() 
        {
            context.Send((state) => { richTextBox1.Text = "\r\n正在生成 Kotlin 的定义源代码..."; }, null);
            StringBuilder codeBuilder = new StringBuilder("data class RegionDivision(\r\n");
            codeBuilder.AppendLine("\tvar id: Int,");
            codeBuilder.AppendLine("\tvar pid: Int,");
            codeBuilder.AppendLine("\tvar name: String,");
            codeBuilder.AppendLine("\tvar zipCode: Long = 0x0000000000000000");
            codeBuilder.AppendLine(");");
            codeBuilder.AppendLine("//---------------------------------");
            codeBuilder.AppendLine("val areas: MutableMap<Int, RegionDivision> = mutableMapOf();");
            foreach (RegionDivision rd in divisions)
                codeBuilder.AppendLine($"areas[{rd.id}] = RegionDivision({rd.id}, {rd.pid}, \"{rd.name}\", {rd.zipCode});");
            context.Send((state) => { 
                richTextBox1.Text = codeBuilder.ToString();
                panel1.Enabled = true;
            }, null);
        }

        /// <summary>
        /// 调用代码生成（将启动一个任务线程）.
        /// </summary>
        private void CodeGenerate()
        {
            if (divisions == null || divisions.Count < 1)
            {
                richTextBox1.Text = "未加载中华人民共和国行政区划数据，代码生成已终止.";
                return;
            }
            Action threadFun = radioGenerateKotlin.Checked ? GenerateKotlin : GenerateCsharp;
            panel1.Enabled = false;
            Task.Factory.StartNew(threadFun);
        }

        /// <summary>
        /// 用于处理按扭的点击事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;

            switch (btn.Name)
            {
                case "browserButton":
                    OpenFile();
                    break;
                case "generateButton":
                    CodeGenerate();
                    break;
            }
        }
    }
}
