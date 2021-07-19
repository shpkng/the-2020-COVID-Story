// Author: wuchenyang(shpkng@gmail.com)

using SQLite;
using Newtonsoft.Json;
using System.Collections.Generic;

[Table("WorldEvent")]
public class WorldEvent : DataItem
{
    public List<int> dependencyIds;
    [Column("dependency_ids")]
    public string dependencyIdStr
    {
        get => JsonConvert.SerializeObject(dependencyIds);
        set => dependencyIds = JsonConvert.DeserializeObject<List<int>>(value);
    }
    public bool AllDependenciesMet => dependencyIds.Count == 0;



    public void CompleteDependency(int id)
    {
        dependencyIds.Remove(id);
        if (AllDependenciesMet)
            Trigger();

    }

    public void Trigger()
    {

    }
}