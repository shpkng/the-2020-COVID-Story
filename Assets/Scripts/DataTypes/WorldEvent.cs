// Author: wuchenyang(shpkng@gmail.com)

using SQLite;

[Table("WorldEvent")]
public class WorldEvent : DataItem
{
    private WorldEventDependency[] _eventDependencies;
    public bool AllDependenciesMet => _eventDependencies.Length == 0;

    public override void Read()
    {
        throw new System.NotImplementedException();
    }

    public override void Write()
    {
        throw new System.NotImplementedException();
    }

    public override void Merge(bool @override)
    {
        throw new System.NotImplementedException();
    }
}