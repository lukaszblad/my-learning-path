namespace attributes;

public class IgnoringJSON
{
    [JsonIgnore]
    public string notSerializable = "This string is not serializable";
    public string serializable = "The next string is already serializable";
}
