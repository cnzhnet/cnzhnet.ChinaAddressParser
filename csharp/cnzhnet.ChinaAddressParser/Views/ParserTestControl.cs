using System;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace cnzhnet.ChinaAddressParser.Views
{
    public partial class ParserTestControl : UserControl
    {
        private AddressParser parser;

        public ParserTestControl()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode)
                return;
            parser = new AddressParser();
        }

        private void ParseAddress()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                richTextBox1.Text = "请输入地址信息.";
                textBox1.Focus();
            }
            try
            {
                AddressInformation address = parser.Parse(textBox1.Text);
                richTextBox1.Text = JsonConvert.SerializeObject(address, Formatting.Indented);
            }
            catch (Exception Ex)
            {
                richTextBox1.Text = Ex.Message;
                richTextBox1.AppendText($"\r\n{Ex.StackTrace}");
            }
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null)
                return;
            switch (btn.Name)
            {
                case "parseButton":
                    ParseAddress();
                    break;
            }
        }
    }
}
