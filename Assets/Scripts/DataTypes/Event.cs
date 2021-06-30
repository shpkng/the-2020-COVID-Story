// Author: wuchenyang(shpkng@gmail.com)

public struct Event:IDatum
{
    private EventDependency[] _eventDependencies;
    public  bool AllDependenciesMet => _eventDependencies.Length == 0;
    public uint id { get; }
    public void Read()
    {
        throw new System.NotImplementedException();
    }

    public void Write()
    {
        throw new System.NotImplementedException();
    }

    public void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}