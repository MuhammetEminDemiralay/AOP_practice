// See https://aka.ms/new-console-template for more information
using Castle.DynamicProxy;
using Entities;
using InvocationApp.Aspects;

Console.WriteLine("Hello, World!");

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<Employee>(new DefensiveProgramingAspect(), new InterceptionAspect());

var emp1 = new Employee
{
    Id = 1,
    FirstName = "Muhammet",

};

aspect.Add(emp1.Id, emp1.FirstName, emp1.LastName);
Console.ReadKey();