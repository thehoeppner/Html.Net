using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlNet.Elements.Common
{
    public class DIVContainer : Base.Container
    {
        private const string DivTag = "div";
        public override string GetHtml()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Base.Element el in Elements)
            {
                sb.AppendLine(el.GetHtml());
            }
            Tag tag = new Tag(DivTag, sb.ToString());
            return tag.GetHtml();
        }
    }
}
