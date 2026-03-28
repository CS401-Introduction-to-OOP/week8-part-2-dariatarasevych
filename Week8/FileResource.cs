namespace Week8;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("File is open");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("File is closed");
    }
    public void Dispose()
    {
        Console.WriteLine($"Call Close() for file {Name} and this is diagnostic message");
        Close();
    }
}