/*
The Template Method pattern defines the skeleton of an
algorithm in the base class but allows subclasses to fill
in or alter certain steps of the algorithm. Think of it
as a cake recipe where the ingredients may vary, but the
main steps are the same.
*/
namespace DesignPatternsSamples.ComportamentalPattern;

// Abstract class that defines the template method
public abstract class AbstractClass
{
    // Template method
    public void TemplateMethod()
    {
        StepOne();
        StepTwo();
        StepThree();
    }

    protected abstract void StepOne();
    protected abstract void StepTwo();
    protected abstract void StepThree();
}

// Concrete class that implements the steps
public class ConcreteClass : AbstractClass
{
    protected override void StepOne() { /* Implementation of step one */ }
    protected override void StepTwo() { /* Implementation of step two */ }
    protected override void StepThree() { /* Implementation of step three */ }
}