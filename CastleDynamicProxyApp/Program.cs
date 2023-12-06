// See https://aka.ms/new-console-template for more information
using Castle.DynamicProxy;

Console.WriteLine("Hello, World!");


var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<MyClass>(new MyInterceptorAspect());
aspect.MyMethod();
Console.ReadLine();


public class MyInterceptorAspect : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        Console.WriteLine("Before {0}", invocation.Method);
        invocation.Proceed();
        Console.WriteLine("After {0}", invocation.Method);
    }
}

public class MyClass
{
    public virtual void MyMethod()
    {
        Console.WriteLine("MyMethod body");
    }
}
