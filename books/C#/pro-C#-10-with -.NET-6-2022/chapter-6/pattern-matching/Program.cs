using pattern_matching;

object myManager = new Manager();

switch(myManager)
{
    case SalesPerson s when s.SalesNumber > 5:
        break;
    case Manager m:
        break;
}