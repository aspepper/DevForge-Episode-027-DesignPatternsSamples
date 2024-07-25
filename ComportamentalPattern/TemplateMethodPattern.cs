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