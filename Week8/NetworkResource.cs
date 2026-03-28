namespace Week8;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name)
    {
    }
    public override void Open()
    {
        IsOpen = true;
        Console.WriteLine("File is open (NetworkResource)");
    }
    public override void Close()
    {
        IsOpen = false;
        Console.WriteLine("File is closed (NetworkResource)");
    }
    public void Dispose()
    {
        Console.WriteLine($"Call Close() for file {Name} and this is diagnostic message (NetworkResource)");
        Close();
    }
}