using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class User
    {
        public string FullName { get; }

        public User(string fullName)
        {
            FullName = fullName;
        }
    }

}
