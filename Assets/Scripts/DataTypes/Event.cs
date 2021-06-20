// Author: wuchenyang(shpkng@gmail.com)

public struct Event
{
    private uint id;
    private EventDependency[] _eventDependencies;
    public  bool AllDependenciesMet => _eventDependencies.Length == 0;
}