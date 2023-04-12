
BaseClass bc = new BaseClass();
DerivedClass dc = new DerivedClass();
BaseClass bcdc = new DerivedClass();
// calling the function of base class 
bc.Method1();
bc.Method2();
// calling the functions of derived class
dc.Method1();
dc.Method2();
// calling the functions of dervied class
bcdc.Method1();
bcdc.Method2();


class BaseClass
{
    public virtual void Method1()
    {
        Console.WriteLine("Base - Method1");
    }

    public virtual void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
}

class DerivedClass : BaseClass
{
    public override void Method1()
    {
        Console.WriteLine("Derived - Method1");
    }

    public override void Method2()
    {
        Console.WriteLine("Derived - Method2");
    }
}
