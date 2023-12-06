// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public interface IBusinessModule
{
    void Method();
}

public class BusinessModule : IBusinessModule
{
    public void Method()
    {
        Console.WriteLine("Method...");
    }
}

public class BusinessModuleProxy : IBusinessModule
{
    private BusinessModule _realSubject;

    public BusinessModuleProxy(BusinessModule realSubject)
    {
        _realSubject = realSubject;
    }

    public void Method()
    {
        Console.WriteLine("Before method");
        _realSubject.Method();
        Console.WriteLine("After method");
    }
}