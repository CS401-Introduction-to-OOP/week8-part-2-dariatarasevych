namespace Week8;
using System.Collections.Generic;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    public void OpenAll()
    {
        Console.WriteLine("Open All resources:");
        foreach (var res in _resources)
        {
            res.Open();
        }
    }
    public void CloseAll()
    {
        Console.WriteLine("Close All resources:");
        foreach (var res in _resources)
        {
            res.Close();
        }
    }
}