using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlNet.Elements.Base
{
    public abstract class Container : Element
    {

        private HashSet<Element> elements = new HashSet<Element>();
        public HashSet<Element> Elements
        {
            get { return elements; }
            set {
                if(!Equals(elements, value))
                {
                    elements = value;
                }
            }
        }

    }
}
