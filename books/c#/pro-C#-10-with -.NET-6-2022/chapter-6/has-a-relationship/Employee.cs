namespace has_a_relationship;

public class Employee
{
    protected BenefitPackage EmpBenefitPackage = new BenefitPackage();

    // Expose certain benefit behaviors of object. 
    public double GetBenefitCost()
     => EmpBenefitPackage.ComputePayDeduction();
    // Expose object through a custom property. 
    public BenefitPackage Benefits
    {
        get { return EmpBenefitPackage; } 
        set { EmpBenefitPackage = value; }
    }
}
