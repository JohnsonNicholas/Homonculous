using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB118_CrewHistoryApp
{
    public class SB118HeaderAttribute : System.Attribute
    {
        private string _value;

        public SB118HeaderAttribute(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }

    }
}
