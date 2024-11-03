namespace pointer_types;

unsafe struct Node
{
    public int Value;

    // unsafe keyword to grant access only in an unsafe scope
    public unsafe Node* Left;
    public unsafe Node* Right;
}
