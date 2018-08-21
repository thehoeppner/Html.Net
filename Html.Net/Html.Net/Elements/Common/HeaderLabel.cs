using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlNet.Elements.Common
{
    public class HeaderLabel : Base.Element
    {
        private int size = 1;
        public int Size { get { return size; }
            set {
                if(size != value && value < 7)
                {
                    size = value;
                }
            } }
        private const string HTag = "h";
        public string Text { get; set; }
        public override string GetHtml()
        {

            Tag tag = new Tag($"{HTag}{size}", Text);
            return tag.GetHtml();
        }
    }
}
