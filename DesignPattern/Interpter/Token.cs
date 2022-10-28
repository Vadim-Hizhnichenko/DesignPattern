using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpter
{
    public partial class Token
    {

        public Type MyType;
        public string Text;

        public Token(Type type, string text)
        {
            MyType = type;
            Text = text;
        }

        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
