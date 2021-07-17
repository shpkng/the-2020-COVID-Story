// Author: wuchenyang(shpkng@gmail.com)

using SQLite;
using Newtonsoft.Json;

enum EventDependencyType
{
    ReadTwitter,
    PostTwitter,

    GetNewFriend,
    ApplyNewFriend,
    AcceptNewFriend,

    ReadMessage,
    SendMessage,
}

[Table("WorldEventDependency")]
public class WorldEventDependency : DataItem
{
    private int[] relatedEventIds;
    [Column("related_events")]
    public string reletedEventIdStr
    {
        get => JsonConvert.SerializeObject(relatedEventIds);
        set => relatedEventIds = JsonConvert.DeserializeObject<int[]>(value);
    }
    [Column("condition_id")] public int conditionId { get; set; }
    [Column("")] public float marker { get; set; }

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

    public void UpdateDependency(int type, params object[] args)
    {
        foreach (int eventId in relatedEventIds)
        {
            var item = WorldEventContainer.Get(eventId);
            if (item == null)
                continue;
            var dependencyType = (EventDependencyType)type;
            switch (dependencyType)
            {
                case EventDependencyType.AcceptNewFriend:
                    continue;
                    
            }
            item.CompleteDependency(id);
        }
    }
}