using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    class Rule
    {
        String code;

        public String RuleID
        {
            get { return code; }
            set { code = value; }
        }

        string content;
        public String Content
        {
            get { return content; }
            set { content = value; }
        }
    }
}
