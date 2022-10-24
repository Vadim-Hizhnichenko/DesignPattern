using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class FunctionakBuilder<TSubject, TSelf> 
        where TSelf : FunctionakBuilder<TSubject, TSelf>
        where TSubject : new()
    {
        public readonly List<Func<TSubject, TSelf>> Actions = new List<Func<TSubject, TSelf>>();
         
    }
}
