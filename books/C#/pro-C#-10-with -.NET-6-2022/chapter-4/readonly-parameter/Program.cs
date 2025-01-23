int a = 10;
int b = 9;
AddReadOnly(a, b);

// in keyword passes the parameter by reference, but it cannot be modified
static int AddReadOnly(in int x, in int y)
{
    //Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable 
    //x = 10000;
    //y = 88888;
    int ans = x + y;
    return ans;
}
