namespace method_overriding;

public class SalesPerson : Employee
{
    public override string CanBeOverridden()
    {
        base.CanBeOverridden();
        return "Overrided by SalesPerson";
    }
}
