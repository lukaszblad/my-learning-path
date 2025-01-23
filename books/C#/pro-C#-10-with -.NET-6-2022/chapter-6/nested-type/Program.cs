using nested_type;

// Create and use the public inner class. OK! 
OuterClass.PublicInnerClass inner;
inner = new OuterClass.PublicInnerClass();
// Compiler Error! Cannot access the private class. 
// OuterClass.PrivateInnerClass inner2;
// inner2 = new OuterClass.PrivateInnerClass();