// Author: wuchenyang(shpkng@gmail.com)

using SQLite;

[Table("WorldEvent")]
public class WorldEvent : DataItem
{
    private WorldEventDependency[] dependencies;
    [Column("dependency_ids")] public int[] dependencyIds { get; set; }
    public bool AllDependenciesMet => dependencies.Length == 0;

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