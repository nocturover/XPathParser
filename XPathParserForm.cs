using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClipboardAssist;

namespace XPathParser
{
    public partial class XPathParserForm : Form
    {
        public XPathParserForm()
        {
            InitializeComponent();
            InitializeConfigures();
        }

        private void InitializeConfigures()
        {
            foreach (CheckBox chk in this.Controls.OfType<CheckBox>())
            {
                chk.Checked = true;
            }

            ClipboardMonitor clipMonitor = new();
            clipMonitor.ClipboardChanged += Clipboard_Changed;
        }

        bool IsInternalSetText = false;
        private void Clipboard_Changed(object sender, ClipboardChangedEventArgs e)
        {
            if (IsInternalSetText) return;

            string[] formats = e.DataObject.GetFormats(true);
            //txtCopied.Text = formats.Aggregate((x, y) => x + "," + y);
            string originStr = e.DataObject.GetData(formats[0]).ToString();
            StringBuilder parsedSb = new();
            parsedSb.Append('"'); parsedSb.Append(originStr.Replace('"', '\'')); parsedSb.Append('"');

            txtCopied.Text = originStr;
            if (chkByXpath.Checked)
            {
                parsedSb.Insert(0, "driver.FindElement(By.XPath(");
                parsedSb.Append("))");
            }
            if (chkAutoCopy.Checked)
            {
                IsInternalSetText = true;
                Clipboard.SetText(parsedSb.ToString());
            }
            txtParsedStr.Text = parsedSb.ToString();
            parsedSb.Clear();
            IsInternalSetText = false;
        }

    }
}
