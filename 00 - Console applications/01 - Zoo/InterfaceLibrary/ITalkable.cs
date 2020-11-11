namespace InterfaceLibrary
{
    /// <summary>
    /// Defines a generalized type-specific talking method that a class implements
    /// </summary>
    public interface ITalkable
    {
        public void Talk();
        public void Talk(string message);
    }
}