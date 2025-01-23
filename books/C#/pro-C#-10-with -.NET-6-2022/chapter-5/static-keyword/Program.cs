using static_keyword;
Console.WriteLine("***** Fun with Static Data *****\n");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);
// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());
// Make new object, this does NOT 'reset' the interest rate.
SavingsAccount s3 = new SavingsAccount(10000.75);
SavingsAccount.SetInterestRate(10.0);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

// Simply put, static members are items that are deemed (by the class designer) to be so commonplace 
// that there is no need to create an instance of the class before invoking the member.

// Compiler error! WriteLine() is not an object level method! 
// Console c = new Console();
// c.WriteLine("I can't be printed...");
// Instead, simply prefix the class name to the static WriteLine() member.
// Correct! WriteLine() is a static method. 
Console.WriteLine("Much better! Thanks...");
