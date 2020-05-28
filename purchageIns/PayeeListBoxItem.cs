using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace purchageIns
{
    class PayeeListBoxItem
    {
        public string c_code { get; set; }
        public string name { get; set; }
        public PayeeListBoxItem(string c_code, string name)
        {
            this.c_code = c_code;
            this.name = name;
        }
        public override string ToString()
        {
            return this.name;
        }
    }
}
