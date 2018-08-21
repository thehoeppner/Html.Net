using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTests
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdGenerateHtml_Click(object sender, EventArgs e)
        {
            HtmlNet.Elements.Common.DIVContainer container = new HtmlNet.Elements.Common.DIVContainer();
            container.Elements.Add(
                new HtmlNet.Elements.Common.HeaderLabel() { Text = "Hallo" });
            container.Elements.Add(
                new HtmlNet.Elements.Common.HeaderLabel() { Text = "Wie gehts" });

            HtmlNet.Elements.Common.DIVContainer innerContainer = new HtmlNet.Elements.Common.DIVContainer();
            innerContainer.Elements.Add(
                new HtmlNet.Elements.Common.HeaderLabel() { Text = "Inner Hallo", Size = 3 });
            innerContainer.Elements.Add(
                new HtmlNet.Elements.Common.HeaderLabel() { Text = "Inner Wie gehts", Size = 3 });
            container.Elements.Add(innerContainer);

            txtHtml.Text = container.GetHtml();
            browser.DocumentText = container.GetHtml();
        }
    }
}
