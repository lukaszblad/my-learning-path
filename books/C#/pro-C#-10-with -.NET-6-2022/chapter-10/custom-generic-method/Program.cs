static void Swap<T>(ref T a, ref T b)
{
    T temp = a;
    a = b;
    b = temp;
}

string first = "First";
string second = "Second";

Swap<string>(ref first, ref second);
