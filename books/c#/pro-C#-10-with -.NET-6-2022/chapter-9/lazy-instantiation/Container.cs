namespace lazy_instantiation;

public class Container
{
    // lazy object instantiation is used to decrease allocation of unnecessary objects
    private Lazy<ExpensiveObject> lazyExpensiveObject = new Lazy<ExpensiveObject>();
}
