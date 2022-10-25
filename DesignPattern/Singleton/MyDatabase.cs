using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class MyDatabase
    {
        private MyDatabase()
        {
            Console.WriteLine("Initializing database");
        }
        private static Lazy<MyDatabase> instance =
          new Lazy<MyDatabase>(() => new MyDatabase());

        public static MyDatabase Instance => instance.Value;
    }
}
