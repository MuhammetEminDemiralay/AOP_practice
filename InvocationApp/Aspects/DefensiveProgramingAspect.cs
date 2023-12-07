using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvocationApp.Aspects
{
    public class DefensiveProgramingAspect : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var arguments = invocation.Arguments;
            foreach(var p in arguments)
            {
                if (p.Equals(null))
                    throw new ArgumentNullException();
            }

            Console.WriteLine("Null check has been completed for {0}", invocation.Method);
        }
    }
}
