using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlNet.Elements
{
    public class Tag
    {
        private string tag;
        private string content;
        private bool HasContent { get { return !string.IsNullOrWhiteSpace(content); } }
        public Tag(string tag, string content = null)
        {
            this.tag = tag;
            this.content = content;
        }

        public string GetHtml()
        {
            string result;
            if (HasContent)
            {
                result = $"<{tag}>{content}</{tag}>";
            }
            else
            {
                result = $"<{tag}></{tag}>";
            }
            return result;

        }
    }
}
