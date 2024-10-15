namespace FunWithBitwiseOperations
{
    [Flags] // needed to use bitwise operators on enum
    public enum ContactPreferenceEnum
    {
        None = 1,
        Email = 2,
        Phone = 4,
        Ponyexpress = 6
    }
}
